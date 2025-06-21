<template>
  <q-page padding>
    <form-table
      :config="ruleTable_Config"
      v-model:tableData="ruleTableData"
      v-model:pagination="rulePagination"
      :search="ruleSearch"
      :create="ruleCreate"
      :update="ruleUpdate"
      :batchDelete="ruleBatchDelete"
      :delete="ruleDelete"
      :showEditDialogBefore="
        (row) => {
          // 确保 Segments 存在，并进行深拷贝
          if (!row.Segments) {
            row.Segments = []
          }
          segmentPagination.rowsNumber = row.Segments.length
          segmentPagination.page = 1
        }
      "
      :showAddDialogBefore="
        (formData) => {
          // 为新增记录初始化空的 Segments 数组
          formData.Segments = []
          segmentPagination.rowsNumber = 0
          segmentTableData = []
          segmentPagination.page = 1
        }
      "
    >
      <template #form-header="{ title }">
        <q-card-section>
          <div class="text-h6">{{ title }}编码规则</div>
        </q-card-section>
      </template>
      <template #form-body="{ formData }">
        <div class="row q-col-gutter-md">
          <q-input label="规则编码" v-model="formData.Id" />
          <q-input label="规则名称" v-model="formData.Name" />
          <q-input label="描述" v-model="formData.Description" />
          <q-select
            label="规则编码适用于"
            v-model="formData.ModelTypeName"
            :options="modelTypeNameOptions"
          ></q-select>
          <q-input label="分隔符" v-model="formData.Separator" />
          <q-toggle
            :label="
              formData.IsActive == undefined ? `是否激活` : formData.IsActive ? `激活` : `未激活`
            "
            v-model="formData.IsActive"
            color="green"
            :true-value="true"
            :false-value="false"
          />
        </div>
        <!-- 规则段区域 -->
        <q-separator />
        <div class="text-subtitle2 q-mt-md">规则段:</div>
        <form-table
          v-model:tableData="segmentTableData"
          v-model:pagination="segmentPagination"
          :config="segmentTable_config"
          :create="(payload) => segmentCreate(payload, formData.Segments)"
          :batchDelete="(keys) => segmentBatchDelete(keys, formData.Segments)"
          :delete="(key) => segmentDelete(key, formData.Segments)"
          :update="(payload) => segmentUpdate(payload, formData.Segments)"
          :search="(queryParams) => segmentSearch(queryParams, formData.Segments)"
        >
        </form-table>
        <!-- 预览区域 -->
        <q-separator />
        <div class="text-subtitle2 q-mt-md">编号预览:</div>
        <q-card flat bordered class="q-pa-sm bg-grey-1">
          <div class="text-body2">previewNumber</div>
        </q-card>
      </template>

      <template #actions-append="{ row }">
        <q-btn
          label="配置权限"
          @click="() => openPermissionDialog(row)"
          dense
          v-permit="orgPermission"
        />
      </template>
    </form-table>
    <!-- 测试生成对话框 -->
    <!-- <q-dialog v-model="showTestDialog">
      <q-card style="min-width: 400px">
        <q-card-section>
          <div class="text-h6">测试生成编号</div>
        </q-card-section>

        <q-card-section>
          <div class="text-body1">规则: {{ testRule?.ruleName }}</div>
          <q-input v-model="testBusinessKey" label="业务关键字 (可选)" class="q-mt-md" />
        </q-card-section>

        <q-card-actions align="right">
          <q-btn flat label="取消" @click="showTestDialog = false" />
          <q-btn color="primary" label="生成" @click="generateTestNumber" />
        </q-card-actions>
      </q-card>
    </q-dialog> -->
  </q-page>
</template>

<script setup>
import { ref } from 'vue'
import { useCodeRuleStore } from 'src/stores/codeRule'
import { uid } from 'quasar'

const codeRuleStore = useCodeRuleStore()

const ruleTable_Config = {
  queryFields: null,
  tableConfig: {
    rowKey: 'dtId',
    selection: 'multiple',
    columns: [
      { name: 'Id', align: 'left', label: '规则编码', field: 'Id', sortable: true },
      { name: 'Name', align: 'left', label: '规则名称', field: 'Name', sortable: true },
      { name: 'Description', align: 'left', label: '描述', field: 'Description' },
      {
        name: 'ModelTypeName',
        align: 'left',
        label: '适用于',
        field: 'ModelTypeName',
      },
      { name: 'Separator', align: 'left', label: '分隔符', field: 'Separator' },
      { name: 'IsActive', align: 'left', label: '是否激活', field: 'IsActive' },
    ],
  },
}
const segmentTable_config = {
  queryFields: null,
  tableConfig: {
    rowKey: 'Key',
    selection: 'multiple',
    columns: [
      { name: 'Order', align: 'center', label: '序号', field: 'Order' },
      { name: 'Type', align: 'center', label: '类型', field: 'Type' },
      { name: 'Value', align: 'center', label: '值', field: 'Value' },
      { name: 'Format', align: 'center', label: '格式化字符串', field: 'Format' },
      { name: 'Length', align: 'center', label: '固定长度', field: 'Length' },
      { name: 'PaddingChar', align: 'center', label: '填充字符', field: 'PaddingChar' },
      { name: 'PadLeft', align: 'center', label: '填充方向', field: 'PadLeft' },
    ],
  },
  formFields: {
    Key: {
      show: false,
      type: 'q-input',
      label: '数据库唯一标识',
      defaultValue: uid(),
    },
    Order: {
      type: 'q-input',
      label: '序号',
    },
    Type: {
      type: 'q-select',
      label: '类型',
      props: {
        outlined: true,
        options: [
          {
            label: '固定值',
            value: 'Fixed',
          },
          {
            label: '模型属性',
            value: 'Property',
          },
          {
            label: '序列号',
            value: 'Sequence',
          },
          {
            label: '日期时间',
            value: 'DateTime',
          },
          {
            label: '自定义逻辑',
            value: 'Custom',
          },
        ],
        'option-value': 'value',
        'option-label': 'label',
        'emit-value': true,
        'map-options': true,
      },
    },
    Value: {
      type: 'q-input',
      label: '值',
    },
    Format: {
      type: 'q-input',
      label: '格式化字符串',
    },
    Length: {
      type: 'q-input',
      label: '固定长度',
    },
    PaddingChar: {
      type: 'q-input',
      label: '填充字符',
    },
    PadLeft: {
      type: 'q-btn-toggle',
      // 添加默认值配置
      defaultValue: true,
      // 添加值更新处理器
      onUpdate: (val, formData) => {
        formData.PadLeft = val
      },
      props: {
        'no-caps': true,
        rounded: true,
        unelevated: true,
        'toggle-color': 'primary',
        color: 'white',
        'text-color': 'primary',
        options: [
          { label: '左', value: true },
          { label: '右', value: false },
        ],
      },
    },
  },
}

const modelTypeNameOptions = ref([
  {
    label: '人员',
    value: 'MOM.Domain.isa95.CommonObjectModels.Part2.Personnel.Person',
  },
  {
    label: '人员类',
    value: 'MOM.Domain.isa95.CommonObjectModels.Part2.Personnel.PersonnelClass',
  },
  {
    label: '设备角色层次',
    value: 'MOM.Domain.isa95.CommonObjectModels.HierarchyScope',
  },
  {
    label: '设备',
    value: 'MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.Equipment',
  },
  {
    label: '设备类',
    value: 'MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.EquipmentClass',
  },
  {
    label: '资产',
    value: 'MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAsset',
  },
  {
    label: '资产类',
    value: 'MOM.Domain.isa95.CommonObjectModels.Part2.PhysicalAssetAndEquipment.PhysicalAssetClass',
  },
])

const ruleTableData = ref([])
const rulePagination = ref({
  page: 1,
  rowsPerPage: 10,
  rowsNumber: 0,
})
const segmentTableData = ref([])
const segmentPagination = ref({
  page: 1,
  rowsPerPage: 1,
  rowsNumber: 0,
})

const ruleSearch = async (queryParams) => {
  const response = await codeRuleStore.GetPaged(queryParams)
  ruleTableData.value = response.data
  rulePagination.value.rowsNumber = response.totalItems
}
const segmentSearch = (queryParams, segments) => {
  segmentPagination.value.rowsNumber = segments.length
  // 计算分页的起始和结束索引
  const startIndex = (queryParams.page - 1) * queryParams.pageSize
  const endIndex = startIndex + queryParams.pageSize
  // 使用 slice 获取当前页的数据
  segmentTableData.value = segments.slice(startIndex, endIndex)
}
const ruleCreate = async (payload) => {
  await codeRuleStore.AddHierarchyScope(payload)
}
const segmentCreate = (payload, segments) => {
  segments.push(payload)
  segmentTable_config.formFields.Key.defaultValue = uid()
}
const ruleBatchDelete = async (dtIds) => {
  await rule_batchDelete(dtIds)
}
const segmentBatchDelete = (keys, segments) => {
  // 使用 filter 创建新数组再替换原数组
  const newSegments = segments.filter((segment) => !keys.includes(segment.Key))
  segments.splice(0, segments.length, ...newSegments)
}
const ruleDelete = async (dtId) => {
  await rule_batchDelete([dtId])
}
const segmentDelete = (key, segments) => {
  segmentBatchDelete([key], segments)
}
const rule_batchDelete = async (keys) => {
  await codeRuleStore.DeleteHierarchyScope(keys)
}
const ruleUpdate = async (payload) => {
  await codeRuleStore.UpdateHierarchyScope(payload)
}
const segmentUpdate = async (payload, segments) => {
  // 使用 map 创建新数组，替换 id 为 1 的对象
  const updatedData = segments.map((obj) => {
    if (obj.Key === payload.Key) {
      // 返回一个新对象（避免直接修改原对象）
      return { ...payload }
    }
    return obj
  })

  // 重新赋值到 reactive 数组（确保响应式更新）
  segments.splice(0, segments.length, ...updatedData)
}
</script>
