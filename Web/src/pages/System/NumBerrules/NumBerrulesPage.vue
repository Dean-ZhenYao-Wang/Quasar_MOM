<template>
  <q-page padding>
    <form-table
      :config="ruleTable_Config"
      v-model:tableData="ruleTableData"
      v-model:pagination="rulePagination"
      :search="ruleSearch"
      :create="ruleCreate"
      :update="ruleUpdate"
      :showEditDialogBefore="
        (row) => {
          // 确保 segments 存在，并进行深拷贝
          if (!row.segments) {
            row.segments = []
          }
          segmentPagination.rowsNumber = row.segments.length
          segmentPagination.page = 1
        }
      "
      :showAddDialogBefore="
        (formData) => {
          // 为新增记录初始化空的 segments 数组
          formData.segments = []
          segmentPagination.rowsNumber = 0
          segmentTableData = []
          segmentPagination.page = 1
        }
      "
    >
      <template #body-cell-modelTypeName="{ row }">{{
        getLabelByValue(row.modelTypeName)
      }}</template>
      <template #form-header="{ title }">
        <q-card-section>
          <div class="text-h6">{{ title }}编码规则</div>
        </q-card-section>
      </template>
      <template #form-body="{ formData, readonly }">
        <div class="row q-col-gutter-md">
          <q-input label="规则编码" v-model="formData.id" :readonly="readonly" />
          <q-input label="规则名称" v-model="formData.name" :readonly="readonly" />
          <q-input label="描述" v-model="formData.description" :readonly="readonly" />
          <q-select
            outlined
            style="width: 200px"
            label="规则编码适用于"
            v-model="formData.modelTypeName"
            :options="modelTypeNameOptions"
            option-value="value"
            emit-value
            map-options
            :readonly="readonly"
          ></q-select>
          <q-input label="分隔符" v-model="formData.separator" :readonly="readonly" />
          <q-toggle
            :label="
              formData.IsActive == undefined ? `是否激活` : formData.isActive ? `激活` : `未激活`
            "
            v-model="formData.isActive"
            color="green"
            :true-value="true"
            :false-value="false"
            :disable="readonly"
          />
        </div>
        <!-- 规则段区域 -->
        <q-separator />
        <div class="text-subtitle2 q-mt-md">规则段:</div>
        <form-table
          v-model:tableData="segmentTableData"
          v-model:pagination="segmentPagination"
          :config="{
            ...segmentTable_config,
            tableConfig: {
              ...segmentTable_config.tableConfig,
              add: !readonly,
              delete: !readonly,
            },
          }"
          :create="(payload) => segmentCreate(payload, formData.segments)"
          :batchDelete="(dtIds) => segmentBatchDelete(dtIds, formData.segments)"
          :delete="(dtId) => segmentDelete(dtId, formData.segments)"
          :update="(payload) => segmentUpdate(payload, formData.segments)"
          :search="(queryParams) => segmentSearch(queryParams, formData.segments)"
          :showAddDialogBefore="
            (row) => {
              // 为新增记录初始化空的 segments 数组
              row.dtId = uid()
              if (readonly) {
                segmentTable_config.add = false
                segmentTable_config.delete = false
              }
            }
          "
        >
        </form-table>
        <template v-if="readonly">
          <!-- 预览区域 -->
          <q-separator />
          <div class="text-subtitle2 q-mt-md">编号预览:</div>
          <q-btn label="生成" color="primary" @click="generateTestNumber" />
          <q-card flat bordered class="q-pa-sm bg-grey-1">
            <div class="text-body2">previewNumber</div>
          </q-card>
        </template>
      </template>
    </form-table>
  </q-page>
</template>

<script setup>
import { ref } from 'vue'
import { useCodeRuleStore } from 'src/stores/codeRule'
// import { uid } from 'quasar'

const codeRuleStore = useCodeRuleStore()

const ruleTable_Config = {
  tableConfig: {
    rowKey: 'dtId',
    delete: false,
    selection: 'multiple',
    columns: [
      { name: 'id', align: 'left', label: '规则编码', field: 'Id', sortable: true },
      { name: 'name', align: 'left', label: '规则名称', field: 'name', sortable: true },
      { name: 'description', align: 'left', label: '描述', field: 'description' },
      {
        name: 'modelTypeName',
        align: 'left',
        label: '适用于',
        field: 'modelTypeName',
      },
      { name: 'separator', align: 'left', label: '分隔符', field: 'separator' },
      { name: 'isActive', align: 'left', label: '是否激活', field: 'isActive' },
    ],
  },
}
const segmentTable_config = {
  tableConfig: {
    rowKey: 'dtId',
    selection: 'multiple',
    columns: [
      { name: 'order', align: 'center', label: '序号', field: 'order' },
      { name: 'type', align: 'center', label: '类型', field: 'type' },
      { name: 'value', align: 'center', label: '值', field: 'value' },
      { name: 'format', align: 'center', label: '格式化字符串', field: 'format' },
      { name: 'length', align: 'center', label: '固定长度', field: 'length' },
      { name: 'paddingChar', align: 'center', label: '填充字符', field: 'paddingChar' },
      { name: 'padLeft', align: 'center', label: '填充方向', field: 'padLeft' },
    ],
  },
  formFields: {
    order: {
      type: 'q-input',
      label: '序号',
      props: {
        hint: '用于确定该段在最终编码中的位置,生成编码时会按此顺序依次处理各个段',
      },
    },
    type: {
      type: 'q-select',
      label: '类型',
      props: {
        outlined: true,
        options: [
          {
            label: '固定值',
            value: 'Fixed',
            hint: '该段的值是预先设定的固定字符串，不会变化.例如：编码前缀 "PRD"、"ORD" 等',
          },
          {
            label: '模型属性',
            value: 'Property',
            hint: '该段的值来源于EF Core模型的某个属性.例如：产品类别、客户代码等',
          },
          {
            label: '序列号',
            value: 'Sequence',
            hint: '该段的值是自动递增的序列号.支持多个独立的序列，每个序列可以有不同的名称和起始值',
          },
          {
            label: '日期时间',
            value: 'DateTime',
            hint: '该段的值基于当前日期时间生成.支持自定义日期时间格式，如 "yyyyMMdd"、"HHmmss" 等',
          },
          {
            label: '自定义逻辑',
            value: 'Custom',
            hint: '该段的值通过自定义逻辑生成,可通过继承ICodingRuleManager并重写ProcessCustomSegment方法实现',
          },
        ],
        'option-value': 'value',
        'option-label': 'label',
        'emit-value': true,
        'map-options': true,
        // hint: '决定该段的值如何生成,参见下拉框的详细说明',
      },
    },
    value: {
      type: 'q-input',
      label: '值',
      props: {
        hint: '段的值或配置参数, 根据Type的不同,该字段的含义不同:- Fixed: 固定的字符串值 - Property: EF Core模型中的属性名称 - Sequence: 序列的名称标识(可选，默认为"default") - DateTime: 预留字段,主要使用Format字段 - Custom: 自定义逻辑的标识符或参数',
      },
    },
    format: {
      type: 'q-input',
      label: '格式化字符串',
      props: {
        hint: '用于格式化段的值，支持以下场景： - Property类型：当属性值实现IFormattable接口时使用(如DateTime、数字等) - DateTime类型:日期时间格式，如"yyyyMMdd"、"HHmmss"、"yyyy-MM-dd"等 - 其他类型：预留扩展使用',
      },
    },
    length: {
      type: 'q-input',
      label: '固定长度',
      props: {
        hint: ' 当值为0时不限制长度,当值大于0时: - 如果实际值长度超过此值，会被截断, - 如果实际值长度不足此值,会使用PaddingChar进行填充',
      },
    },
    paddingChar: {
      type: 'q-input',
      label: '填充字符',
      props: {
        hint: '当实际值长度小于Length时,使用此字符进行填充.默认为0,常用于序列号的前导零填充',
      },
    },
    padLeft: {
      type: 'q-btn-toggle',
      // 添加默认值配置
      defaultValue: true,
      props: {
        'no-caps': true,
        rounded: true,
        unelevated: true,
        'toggle-color': 'primary',
        color: 'white',
        'text-color': 'primary',
        options: [
          { label: '左', value: true, slot: 'left' },
          { label: '右', value: false, slot: 'right' },
        ],
      },
      slots: {
        left: {
          template: `
          <q-tooltip>左填充（在值的左侧添加填充字符）- 适用于数字序列号</q-tooltip>
          `,
        },
        right: {
          template: `
          <q-tooltip>右填充（在值的右侧添加填充字符）- 适用于字符串值</q-tooltip>
          `,
        },
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
  rowsPerPage: 10,
  rowsNumber: 0,
})

const generateTestNumber = () => {}

const getLabelByValue = (targetValue, defaultLabel = '未找到') => {
  const option = modelTypeNameOptions.value.find((item) => item.value === targetValue)
  return option?.label ?? defaultLabel
}
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
  await codeRuleStore.RegisterRule(payload)
}
const segmentCreate = (payload, segments) => {
  console.log('payload', payload)
  console.log('segments', segments)
  segments.push(payload)
}
const segmentBatchDelete = (dtIds, segments) => {
  // 使用 filter 创建新数组再替换原数组
  const newSegments = segments.filter((segment) => !dtIds.includes(segment.dtId))
  segments.splice(0, segments.length, ...newSegments)
}
const segmentDelete = (dtId, segments) => {
  segmentBatchDelete([dtId], segments)
}
const ruleUpdate = async (payload) => {
  await codeRuleStore.RegisterRule(payload)
}
const segmentUpdate = async (payload, segments) => {
  console.log('segments', segments)
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
