using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YJUI.Model.Dtos
{
   public class CoptgDto:COPTG
    {
        public string MB002 { get; set; } //客户名称
        public string MQ002 { get; set; } //单据名称
        public string ME002 { get; set; } //CMSME 部门名称
        public string NA003 { get; set; } //CMSNA  录入付款条件
        public string CMSMB002 { get; set; } //CMSMB  录入出货工厂
        public string MV002 { get; set; } //CMSMV 录入员工姓名
    }
}
