using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace ApplicationCore.Enums
{
    public enum DbReturnValue
    {
        [EnumMember(Value = "Create Success")]
        [Description("Record created successfully")]
        CreateSuccess = 100,

        [EnumMember(Value = "Update Success")]
        [Description("Record updated successfully")]
        UpdateSuccess = 101,

        [EnumMember(Value = "Not Exists")]
        [Description("Record does not exists")]
        NotExists = 102,

        [EnumMember(Value = "Delete Success")]
        [Description("Record deleted successfully")]
        DeleteSuccess = 103,

        [EnumMember(Value = "Active Try Delete")]
        [Description("Active record can not be deleted")]
        ActiveTryDelete = 104,

        [EnumMember(Value = "Record Exists")]
        [Description("Record exists in database")]
        RecordExists = 105,
        [EnumMember(Value = "Updation Failed")]
        [Description("Record updation failed")]
        UpdationFailed = 106,

        [EnumMember(Value = "Creation Failed")]
        [Description("Record creation failed")]
        CreationFailed = 107,

        [EnumMember(Value = "CompanyNotExist")]
        [Description("Company does not exists")]
        CompanyNotExist = 108,

        [EnumMember(Value = "StoreNotExist")]
        [Description("Store does not exists")]
        StoreNotExist = 109,


        [EnumMember(Value = "UsernameNotExist")]
        [Description("UserName or Password doesn't match")]
        UsernameNotExist = 110,

        [EnumMember(Value = "PassNotMatch")]
        [Description("Password does not match")]
        PassNotMatch = 111,

        [EnumMember(Value = "EmailSent")]
        [Description("Email has been set to reset the password")]
        EmailSent = 112,
    }
}
