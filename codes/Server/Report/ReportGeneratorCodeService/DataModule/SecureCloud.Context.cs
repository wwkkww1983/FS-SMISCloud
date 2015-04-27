﻿//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportGeneratorService.DataModule
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DW_iSecureCloud_EmptyEntities : DbContext
    {
        public DW_iSecureCloud_EmptyEntities()
            : base("name=DW_iSecureCloud_EmptyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BATCH_JOB_EXECUTION> BATCH_JOB_EXECUTION { get; set; }
        public DbSet<BATCH_JOB_EXECUTION_CONTEXT> BATCH_JOB_EXECUTION_CONTEXT { get; set; }
        public DbSet<BATCH_JOB_EXECUTION_PARAMS> BATCH_JOB_EXECUTION_PARAMS { get; set; }
        public DbSet<BATCH_JOB_EXECUTION_SEQ> BATCH_JOB_EXECUTION_SEQ { get; set; }
        public DbSet<BATCH_JOB_INSTANCE> BATCH_JOB_INSTANCE { get; set; }
        public DbSet<BATCH_JOB_SEQ> BATCH_JOB_SEQ { get; set; }
        public DbSet<BATCH_STEP_EXECUTION> BATCH_STEP_EXECUTION { get; set; }
        public DbSet<BATCH_STEP_EXECUTION_CONTEXT> BATCH_STEP_EXECUTION_CONTEXT { get; set; }
        public DbSet<BATCH_STEP_EXECUTION_SEQ> BATCH_STEP_EXECUTION_SEQ { get; set; }
        public DbSet<T_AGG__DAY_SAFETY_FACTOR_SCORE> T_AGG__DAY_SAFETY_FACTOR_SCORE { get; set; }
        public DbSet<T_AGG__DAY_STRUCTURE_SCORE> T_AGG__DAY_STRUCTURE_SCORE { get; set; }
        public DbSet<T_AGG__HOUR_SAFETY_FACTOR_SCORE> T_AGG__HOUR_SAFETY_FACTOR_SCORE { get; set; }
        public DbSet<T_AGG__HOUR_STRUCTURE_SCORE> T_AGG__HOUR_STRUCTURE_SCORE { get; set; }
        public DbSet<T_AGG__MONTH_SAFETY_FACTOR_SCORE> T_AGG__MONTH_SAFETY_FACTOR_SCORE { get; set; }
        public DbSet<T_AGG__MONTH_STRUCTURE_SCORE> T_AGG__MONTH_STRUCTURE_SCORE { get; set; }
        public DbSet<T_AGG__WEEK_STRUCTURE_SCORE> T_AGG__WEEK_STRUCTURE_SCORE { get; set; }
        public DbSet<T_AGG_WEEK_SAFETY_FACTOR_SCORE> T_AGG_WEEK_SAFETY_FACTOR_SCORE { get; set; }
        public DbSet<T_API_LOG> T_API_LOG { get; set; }
        public DbSet<T_API_RESOURCE> T_API_RESOURCE { get; set; }
        public DbSet<T_COL_ORIGINAL_DATAVALUE> T_COL_ORIGINAL_DATAVALUE { get; set; }
        public DbSet<T_DATA_AGGREGATION> T_DATA_AGGREGATION { get; set; }
        public DbSet<T_DATA_LATEST> T_DATA_LATEST { get; set; }
        public DbSet<T_DATA_ORIGINAL> T_DATA_ORIGINAL { get; set; }
        public DbSet<T_DATA_ORIGINAL_ARCHIVE> T_DATA_ORIGINAL_ARCHIVE { get; set; }
        public DbSet<T_DATA_RATIONAL_FILTER_CONFIG> T_DATA_RATIONAL_FILTER_CONFIG { get; set; }
        public DbSet<T_DATA_STABLE_FILTER_CONFIG> T_DATA_STABLE_FILTER_CONFIG { get; set; }
        public DbSet<T_DIM_COMPANY> T_DIM_COMPANY { get; set; }
        public DbSet<T_DIM_CORRELATION_FACTOR> T_DIM_CORRELATION_FACTOR { get; set; }
        public DbSet<T_DIM_DAI> T_DIM_DAI { get; set; }
        public DbSet<T_DIM_DAI_PRODUCT> T_DIM_DAI_PRODUCT { get; set; }
        public DbSet<T_DIM_DATETIME> T_DIM_DATETIME { get; set; }
        public DbSet<T_DIM_DEVICETOKEN> T_DIM_DEVICETOKEN { get; set; }
        public DbSet<T_dim_Dictionary> T_dim_Dictionary { get; set; }
        public DbSet<T_DIM_DTU_PRODUCT> T_DIM_DTU_PRODUCT { get; set; }
        public DbSet<T_DIM_DTU_STATUS> T_DIM_DTU_STATUS { get; set; }
        public DbSet<T_DIM_FORMULA_PARA> T_DIM_FORMULA_PARA { get; set; }
        public DbSet<T_DIM_FORMULA_PARA_NAME> T_DIM_FORMULA_PARA_NAME { get; set; }
        public DbSet<T_DIM_FORMULAID> T_DIM_FORMULAID { get; set; }
        public DbSet<T_DIM_FORMULAID_SET> T_DIM_FORMULAID_SET { get; set; }
        public DbSet<T_DIM_GROUP> T_DIM_GROUP { get; set; }
        public DbSet<T_DIM_GROUP_TYPE> T_DIM_GROUP_TYPE { get; set; }
        public DbSet<T_DIM_HALF_HOUR> T_DIM_HALF_HOUR { get; set; }
        public DbSet<T_DIM_HOTSPOT> T_DIM_HOTSPOT { get; set; }
        public DbSet<T_DIM_HOTSPOT_SECTION> T_DIM_HOTSPOT_SECTION { get; set; }
        public DbSet<T_DIM_HOTSPOTTest> T_DIM_HOTSPOTTest { get; set; }
        public DbSet<T_DIM_HOUR> T_DIM_HOUR { get; set; }
        public DbSet<T_DIM_OPERATION_LOG> T_DIM_OPERATION_LOG { get; set; }
        public DbSet<T_DIM_OPERATION_RESOURCE> T_DIM_OPERATION_RESOURCE { get; set; }
        public DbSet<T_DIM_OPERATION_TYPE> T_DIM_OPERATION_TYPE { get; set; }
        public DbSet<T_DIM_ORG_STUCTURE> T_DIM_ORG_STUCTURE { get; set; }
        public DbSet<T_DIM_ORGANIZATION> T_DIM_ORGANIZATION { get; set; }
        public DbSet<T_DIM_PERMISSION> T_DIM_PERMISSION { get; set; }
        public DbSet<T_DIM_POWER_SUPPLY_TYPE> T_DIM_POWER_SUPPLY_TYPE { get; set; }
        public DbSet<T_DIM_PRODUCT_CATEGORY> T_DIM_PRODUCT_CATEGORY { get; set; }
        public DbSet<T_DIM_PRODUCT_TYPE> T_DIM_PRODUCT_TYPE { get; set; }
        public DbSet<T_DIM_PRODUCTCATAGORY_ORIGINALDATA> T_DIM_PRODUCTCATAGORY_ORIGINALDATA { get; set; }
        public DbSet<T_DIM_PROTOCOL_TYPE> T_DIM_PROTOCOL_TYPE { get; set; }
        public DbSet<T_DIM_PROTOCOLCOMMAND> T_DIM_PROTOCOLCOMMAND { get; set; }
        public DbSet<T_DIM_REGION> T_DIM_REGION { get; set; }
        public DbSet<T_DIM_REGION_TYPE> T_DIM_REGION_TYPE { get; set; }
        public DbSet<T_DIM_REMOTE_DTU> T_DIM_REMOTE_DTU { get; set; }
        public DbSet<T_DIM_ROLE> T_DIM_ROLE { get; set; }
        public DbSet<T_DIM_ROLE_API_RESOURCE> T_DIM_ROLE_API_RESOURCE { get; set; }
        public DbSet<T_DIM_ROLE_RESOURCE> T_DIM_ROLE_RESOURCE { get; set; }
        public DbSet<T_DIM_SAFETY_FACTOR_TYPE> T_DIM_SAFETY_FACTOR_TYPE { get; set; }
        public DbSet<T_DIM_SECTION> T_DIM_SECTION { get; set; }
        public DbSet<T_DIM_SENSOR> T_DIM_SENSOR { get; set; }
        public DbSet<T_DIM_SENSOR_CORRENT> T_DIM_SENSOR_CORRENT { get; set; }
        public DbSet<T_DIM_SENSOR_DATASTATUS> T_DIM_SENSOR_DATASTATUS { get; set; }
        public DbSet<T_DIM_SENSOR_GPS> T_DIM_SENSOR_GPS { get; set; }
        public DbSet<T_DIM_SENSOR_GROUP_CEXIE> T_DIM_SENSOR_GROUP_CEXIE { get; set; }
        public DbSet<T_DIM_SENSOR_GROUP_CHENJIANG> T_DIM_SENSOR_GROUP_CHENJIANG { get; set; }
        public DbSet<T_DIM_SENSOR_GROUP_JINRUNXIAN> T_DIM_SENSOR_GROUP_JINRUNXIAN { get; set; }
        public DbSet<T_DIM_Sensor_Init> T_DIM_Sensor_Init { get; set; }
        public DbSet<T_DIM_SENSOR_PRODUCT> T_DIM_SENSOR_PRODUCT { get; set; }
        public DbSet<T_DIM_SENSORPRODUCT_SAFETYFACTORTYPE> T_DIM_SENSORPRODUCT_SAFETYFACTORTYPE { get; set; }
        public DbSet<T_DIM_STRUCT_DTU> T_DIM_STRUCT_DTU { get; set; }
        public DbSet<T_DIM_STRUCTUER_LINE> T_DIM_STRUCTUER_LINE { get; set; }
        public DbSet<T_DIM_STRUCTUER_PROGRESS> T_DIM_STRUCTUER_PROGRESS { get; set; }
        public DbSet<T_DIM_STRUCTURE> T_DIM_STRUCTURE { get; set; }
        public DbSet<T_DIM_STRUCTURE_FACTOR> T_DIM_STRUCTURE_FACTOR { get; set; }
        public DbSet<T_DIM_STRUCTURE_TYPE> T_DIM_STRUCTURE_TYPE { get; set; }
        public DbSet<T_DIM_STRUCTURE_TYPE_FACTOR> T_DIM_STRUCTURE_TYPE_FACTOR { get; set; }
        public DbSet<T_DIM_USER> T_DIM_USER { get; set; }
        public DbSet<T_DIM_USER_ORG> T_DIM_USER_ORG { get; set; }
        public DbSet<T_DIM_USER_ROLE> T_DIM_USER_ROLE { get; set; }
        public DbSet<T_DIM_USER_STRUCTURE> T_DIM_USER_STRUCTURE { get; set; }
        public DbSet<T_DIM_WARNING_DEVICETYPE> T_DIM_WARNING_DEVICETYPE { get; set; }
        public DbSet<T_DIM_WARNING_TYPE> T_DIM_WARNING_TYPE { get; set; }
        public DbSet<T_FACT_DEFAULTGPS> T_FACT_DEFAULTGPS { get; set; }
        public DbSet<T_FACT_DEFAULTINCLINOMETER> T_FACT_DEFAULTINCLINOMETER { get; set; }
        public DbSet<T_FACT_DEFAULTSENSOR_THRESHOLD> T_FACT_DEFAULTSENSOR_THRESHOLD { get; set; }
        public DbSet<T_FACT_GPS> T_FACT_GPS { get; set; }
        public DbSet<T_FACT_INCLINOMETER> T_FACT_INCLINOMETER { get; set; }
        public DbSet<T_FACT_NORMALIZED> T_FACT_NORMALIZED { get; set; }
        public DbSet<T_FACT_SAFETY_FACTOR_SCORE> T_FACT_SAFETY_FACTOR_SCORE { get; set; }
        public DbSet<T_FACT_SAFETY_FACTOR_WEIGHTS> T_FACT_SAFETY_FACTOR_WEIGHTS { get; set; }
        public DbSet<T_FACT_SENSOR_THRESHOLD> T_FACT_SENSOR_THRESHOLD { get; set; }
        public DbSet<T_FACT_SENSOR_WEIGHTS> T_FACT_SENSOR_WEIGHTS { get; set; }
        public DbSet<T_FACT_STRUCTURE_SCORE> T_FACT_STRUCTURE_SCORE { get; set; }
        public DbSet<T_FACT_SUB_SAFETY_FACTOR_WEIGHTS> T_FACT_SUB_SAFETY_FACTOR_WEIGHTS { get; set; }
        public DbSet<T_FACT_WEIGHT_SCORE> T_FACT_WEIGHT_SCORE { get; set; }
        public DbSet<T_IOS_VERSION> T_IOS_VERSION { get; set; }
        public DbSet<T_REPORT_COLLECTION> T_REPORT_COLLECTION { get; set; }
        public DbSet<T_REPORT_CONFIG> T_REPORT_CONFIG { get; set; }
        public DbSet<T_REPORT_CONFIG_TEMPLATE> T_REPORT_CONFIG_TEMPLATE { get; set; }
        public DbSet<T_REPORT_TEMPLATE> T_REPORT_TEMPLATE { get; set; }
        public DbSet<T_SYSTEM_LOG> T_SYSTEM_LOG { get; set; }
        public DbSet<T_TASK_INSTANT> T_TASK_INSTANT { get; set; }
        public DbSet<T_THEMES_CABLE_FORCE> T_THEMES_CABLE_FORCE { get; set; }
        public DbSet<T_THEMES_DEFORMATION_BRIDGE_DEFLECTION> T_THEMES_DEFORMATION_BRIDGE_DEFLECTION { get; set; }
        public DbSet<T_THEMES_DEFORMATION_CRACK> T_THEMES_DEFORMATION_CRACK { get; set; }
        public DbSet<T_THEMES_DEFORMATION_DEEP_DISPLACEMENT> T_THEMES_DEFORMATION_DEEP_DISPLACEMENT { get; set; }
        public DbSet<T_THEMES_DEFORMATION_DEEP_DISPLACEMENT_DAILY> T_THEMES_DEFORMATION_DEEP_DISPLACEMENT_DAILY { get; set; }
        public DbSet<T_THEMES_DEFORMATION_SETTLEMENT> T_THEMES_DEFORMATION_SETTLEMENT { get; set; }
        public DbSet<T_THEMES_DEFORMATION_SURFACE_DISPLACEMENT> T_THEMES_DEFORMATION_SURFACE_DISPLACEMENT { get; set; }
        public DbSet<T_THEMES_DEFORMATION_SURFACE_DISPLACEMENT_DAILY> T_THEMES_DEFORMATION_SURFACE_DISPLACEMENT_DAILY { get; set; }
        public DbSet<T_THEMES_ENVI_BEACH> T_THEMES_ENVI_BEACH { get; set; }
        public DbSet<T_THEMES_ENVI_RAINFALL> T_THEMES_ENVI_RAINFALL { get; set; }
        public DbSet<T_THEMES_ENVI_SATURATION_LINE> T_THEMES_ENVI_SATURATION_LINE { get; set; }
        public DbSet<T_THEMES_ENVI_SEEPAGE> T_THEMES_ENVI_SEEPAGE { get; set; }
        public DbSet<T_THEMES_ENVI_TEMP_HUMI> T_THEMES_ENVI_TEMP_HUMI { get; set; }
        public DbSet<T_THEMES_ENVI_WATER_LEVEL> T_THEMES_ENVI_WATER_LEVEL { get; set; }
        public DbSet<T_THEMES_ENVI_WIND> T_THEMES_ENVI_WIND { get; set; }
        public DbSet<T_THEMES_FBG_STRESS_STRAIN> T_THEMES_FBG_STRESS_STRAIN { get; set; }
        public DbSet<T_THEMES_FORCE_ANCHOR> T_THEMES_FORCE_ANCHOR { get; set; }
        public DbSet<T_THEMES_FORCE_AXIAL> T_THEMES_FORCE_AXIAL { get; set; }
        public DbSet<T_THEMES_FORCE_BEAM> T_THEMES_FORCE_BEAM { get; set; }
        public DbSet<T_THEMES_FORCE_EARTH_PRESSURE> T_THEMES_FORCE_EARTH_PRESSURE { get; set; }
        public DbSet<T_THEMES_FORCE_STEELBAR> T_THEMES_FORCE_STEELBAR { get; set; }
        public DbSet<T_THEMES_STRESS_STRAIN_PORE_WATER_PRESSURE> T_THEMES_STRESS_STRAIN_PORE_WATER_PRESSURE { get; set; }
        public DbSet<T_THEMES_STRESS_STRAIN_RETAININGWALL> T_THEMES_STRESS_STRAIN_RETAININGWALL { get; set; }
        public DbSet<T_THEMES_VIBRATION> T_THEMES_VIBRATION { get; set; }
        public DbSet<T_THEMES_VIBRATION_ARCHIVE> T_THEMES_VIBRATION_ARCHIVE { get; set; }
        public DbSet<T_THEMES_VIBRATION_BATCH> T_THEMES_VIBRATION_BATCH { get; set; }
        public DbSet<T_THEMES_VIBRATION_BATCH_ARCHIVE> T_THEMES_VIBRATION_BATCH_ARCHIVE { get; set; }
        public DbSet<T_THEMES_VIBRATION_DECK_VIBRATION> T_THEMES_VIBRATION_DECK_VIBRATION { get; set; }
        public DbSet<T_THEMES_VIBRATION_ORIGINAL> T_THEMES_VIBRATION_ORIGINAL { get; set; }
        public DbSet<T_THEMES_VIBRATION_ORIGINAL_ARCHIVE> T_THEMES_VIBRATION_ORIGINAL_ARCHIVE { get; set; }
        public DbSet<T_WARNING_DEALDETAILS> T_WARNING_DEALDETAILS { get; set; }
        public DbSet<T_WARNING_LEVEL> T_WARNING_LEVEL { get; set; }
        public DbSet<T_WARNING_SENSOR> T_WARNING_SENSOR { get; set; }
        public DbSet<T_WARNING_SMS_RECIEVER> T_WARNING_SMS_RECIEVER { get; set; }
    }
}
