using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// PURTC 的摘要说明
    /// </summary>
    public class PURTC : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            if (context.Session["user"] == null)
            {
                context.Response.Write("nosession");
                context.Response.End();
            }
            else if (context.Request.QueryString["action"] == "search")
            {
                string strWhere = "1=1  ";
                //var type = context.Request.Params["type"];
                //var bdate = context.Request.Params["bdate"];
                //var edate = context.Request.Params["edate"];
                //strWhere = NewMethod1(strWhere, type, bdate, edate);
                var pageindex = int.Parse(context.Request["page"]);
                var pagesize = int.Parse(context.Request.Params["rows"]);
                var strjson = BLL.PURTC.Current.GetListToJson(strWhere, "", (pageindex - 1) * pagesize, pageindex * pagesize);
                context.Response.Write(strjson);
                context.Response.End();
            }

            #region 生成进货单
            else if (context.Request.Params["action"] == "add_receipt")
            {
                var db = context.Request.Params["TC001"];
                var dh = context.Request.Params["TC002"];
                var odb = context.Request.Params["TG001"];//选择进货单别
                var odh = BLL.PURTG.Current.GetPurtgErpNo(odb);      //获取进货单单号
                Model.PURTC purtc = BLL.PURTC.Current.GetPURTC(db, dh);
                var purma = BLL.PURMA.Current.GetPURMA(purtc.TC004);//获取单据供应商所有信息
                IEnumerable<Model.PURTD> purtds = BLL.PURTD.Current.GetPurtdList(db, dh);
                Model.PURTG purtg = new Model.PURTG();
                List<Model.PURTH> purths = new List<Model.PURTH>();
                purtg.COMPANY = "WSGC";
                purtg.CREATOR = "mx";
                purtg.FLAG = 1;
                purtg.TG001 = odb;   //进货单别
                purtg.TG002 = odh;   //进货单号
                purtg.TG003 = DateTime.Now.ToString("yyyyMMdd"); ;   //进货日期[FORMATE:YMD]
                purtg.TG004 = purtc.TC010;   //进货工厂
                purtg.TG005 = purtc.TC004;   //供应商
                purtg.TG006 = "";   //供应商单号
                purtg.TG007 = "RMB";   //币种
                purtg.TG008 = 1;    //汇率 
                purtg.TG009 = purma.MA030;   //S.可抵扣专用发票、B.普通发票
                purtg.TG010 = purma.MA044;   //1.应税内含、2.应税外加、3.零
                purtg.TG011 = "";   //发票号码
                purtg.TG012 = 0;    //打印次数
                purtg.TG013 = "N";   //Y:已审核、N:未审核、V:作废 
                purtg.TG014 = DateTime.Now.ToString("yyyyMMdd");   //单据日期[FORMATE:YMD] 
                purtg.TG015 = "N";   //Y/N
                purtg.TG016 = purtc.TC009;   //备注
                purtg.TG017 = purtc.TC019;    //进货金额    
                purtg.TG018 = 0;    //扣款金额   
                purtg.TG019 = 0;    //原币税额   
                purtg.TG020 = 0;    //进货费用   
                purtg.TG021 = purma.MA003;   //供应商全称
                purtg.TG022 = "";   //税号
                purtg.TG023 = "1";   //预留字段 
                purtg.TG024 = "N";   //Y/N &87-09-04 
                purtg.TG025 = 0;    //件数
                purtg.TG026 = purtc.TC023;    //单身的总验收数量
                purtg.TG027 = "";   //发票日期[FORMATE:YMD]
                purtg.TG028 = purtc.TC019;    //原币税前货款金额   
                purtg.TG029 = "";   //预留字段 
                purtg.TG030 = 0;    //增值税率(%)[DEF:9.9999] 
                purtg.TG031 = purtc.TC019;    //本币税前货款金额 
                purtg.TG032 = 0;    //本币税额 
                purtg.TG033 = purma.MA025;   //付款条件编号 
                purtg.TG034 = "";   //预留字段 
                purtg.TG035 = "";   //预留字段 
                purtg.TG036 = "";   //预留字段 
                purtg.TG037 = "";   //预留字段 
                purtg.TG038 = 0;    //预留字段 
                purtg.TG039 = 0;    //预留字段 
                purtg.TG040 = purtc.TC029;    //总验收包装量 
                purtg.TG041 = 0;    //本币冲自筹额 
                purtg.TG042 = "N";   //0.待处理、S.传送中、1.签核中
                purtg.TG043 = "";   //Y/N[DEF:"N"] 
                purtg.TG044 = "";   //海关手册 
                purtg.TG045 = 0;    //传送次数[DEF:0] 
                purtg.TG046 = 0;    //看板总张数 
                purtg.TG047 = "";   //委外进货单别 
                purtg.TG048 = "";   //委外进货单号 
                purtg.TG049 = "10100";   //部门编号 
                purtg.TG050 = "N";   //Y/M/N [DEF:"N"] 
                purtg.TG051 = "";   //预留字段 
                purtg.TG052 = "";   //预留字段 
                purtg.TG053 = purtc.TC023;    //总进货数量 
                purtg.TG054 = purtc.TC029;    //总进货包装量
                purtg.TG055 = 0;    //预留字段 
                purtg.TG056 = "";   //EBC出货通知单号 
                purtg.TG057 = "";   //EBC出货通知版本 
                purtg.TG058 = "0";   //0.ERP 1.EBC [DEF:"0"]
                purtg.TG059 = ""; //项目编号    

                foreach (var item in purtds)
                {
                    Model.PURTH model = new Model.PURTH();
                    model.COMPANY = "WSGC";
                    model.CREATOR = "mx";
                    model.FLAG = 1;
                    model.TH001 = odb;     //单别【Order Type】                                           
                    model.TH002 = odh;      //单号【Order No.】                                            
                    model.TH003 = item.TD003;      //序号【Sequence】                                             
                    model.TH004 = item.TD004;      //品号【Item】                                                 
                    model.TH005 = item.TD005;      //品名【Item Description】                                     
                    model.TH006 = item.TD006;      //规格【Spec】                                                 
                    model.TH007 = item.TD008;       //进货数量【Receipt Quantity】                                 
                    model.TH008 = item.TD009;      //单位【Unit】                                                 
                    model.TH009 = item.TD007;      //仓库【Warehouse】                                            
                    model.TH010 = purtc.TC004;      //批号【Lot】                                                  
                    model.TH011 = item.TD001;      //采购单别【Purchase Order Type】                              
                    model.TH012 = item.TD002;      //采购单号【Purchase Order No.】                               
                    model.TH013 = item.TD003;      //采购序号【Purchase Order Sequence Number】                   
                    model.TH014 = DateTime.Now.ToString("yyyyMMdd");      //验收日期【Inspection Date】                                  
                    model.TH015 = item.TD008;       //验收数量【Accepted Quantity】                                
                    model.TH016 = item.TD008;       //计价数量【Pricing Quantity】                                 
                    model.TH017 = 0;       //验退数量【Inspection Return Quantity】                       
                    model.TH018 = item.TD010;       //原币单位进价【Purchase Price In Original Currency】          
                    model.TH019 = item.TD011;       //原币进货金额【Purchase Receipt Amount In Original Currency】 
                    model.TH020 = 0;       //原币扣款金额【Detain Amount (O/C)】                          
                    model.TH021 = "";      //借入单别【Borrow Order Type】                                
                    model.TH022 = "";      //借入单号【Borrow Order No.】                                 
                    model.TH023 = "";      //借入序号【Borrow Order Sequence】     
                    model.TH024 = 0;       //进货费用【Receipt Expenses】                                 
                    model.TH025 = "";      //扣款说明【Deduction Description】                            
                    model.TH026 = "N";      //暂不付款【Payment Pended】                                   
                    model.TH027 = "N";      //超期码【Overdue Indicator】                                  
                    model.TH028 = "0";      //检验状态【Inspection Status】                                
                    model.TH029 = "N";      //验退码【Inspection Return Indicator】                        
                    model.TH030 = "N";      //审核码【Approve Indicator】                                  
                    model.TH031 = "N";      //开票码【Code bill】                                          
                    model.TH032 = "N";      //更新码【Update Indicator】                                   
                    model.TH033 = "";      //备注【Remark】                                               
                    model.TH034 = item.TD008;       //验收库存数量【Accepted Inventory Quantity】                  
                    model.TH035 = "";      //小单位【Small Unit】                                         
                    model.TH036 = "";      //有效日期【Effective Date】                                   
                    model.TH037 = "";      //复检日期【Reinsepction Date】                                
                    model.TH038 = "";      //审核者【Approver】                                           
                    model.TH039 = "";      //采购发票单别【Purchase Invoice Type】                        
                    model.TH040 = "";      //采购发票单号【Purchase Invoice No.】                         
                    model.TH041 = "";      //采购发票序号【Purchase Invoice Sequence】                    
                    model.TH042 = "";      //项目编号【Project NO.】                                      
                    model.TH043 = "N";      //生成分录【Journalized】                                      
                    model.TH044 = "N";      //冲自筹额码【Prepament Offset】                               
                    model.TH045 = item.TD011;     //原币税前金额【Amount Un-include Tax(O/C)】                   
                    model.TH046 = 0;       //原币税额【Tax(O/C)】                                         
                    model.TH047 = item.TD011;     //本币税前金额【Amount Un-include Tax(B/C)】                   
                    model.TH048 = 0;       //本币税额【Tax(B/C)】                                         
                    model.TH049 = item.TD030;     //进货包装数量【Purchase Receipt Packing Quantity】            
                    model.TH050 = item.TD030;     //验收包装数量【Accepted Packing Quantity】                    
                    model.TH051 = 0;       //验退包装数量【Inspection Return Packing Quantity】           
                    model.TH052 = 0;       //本币冲自筹额【Prepaid Offset Amount(B/C)】                   
                    model.TH053 = item.TD032;      //包装单位【Packing Unit】                                     
                    model.TH054 = 0;       //已开票数量【Has argued that the number of】                  
                    model.TH055 = 0;       //已开票扣款金额【The amount has been made against the ballot】
                    model.TH056 = "";      //存储位置【Storage Location】                                 
                    model.TH057 = "";      //生产日期【Production Date】                                  
                    model.TH058 = item.TD036;       //件装【Pieces Per】                                           
                    model.TH059 = item.TD037;       //件数【Pieces】                                               
                    model.TH060 = 0;       //预留字段【Reserved Field】                                   
                    model.TH061 = 0;       //报废数量【Scrap Quantity】                                   
                    model.TH062 = 0;       //报废包装数量【Scrap Packing Quantity】                       
                    model.TH063 = "";      //预留字段【Reserved Field】                                   
                    model.TH064 = item.TD038;      //计价单位【Pricing Unit】                                     
                    model.TH065 = item.TD009;      //库存单位【Stock Unit】                                       
                    model.TH066 = "";      //原始客户【Original Customer】                                
                    model.TH067 = "";      //批号说明【Lot Description】                                  
                    model.TH068 = 0;       //破坏数量【Destroyed Quantity】                               
                    model.TH069 = 0;       //破坏包装数量【Destroyed Packing Quantity】                   
                    model.TH070 = "N";      //报废码【Scrap Indicator】                                    
                    model.TH071 = 1;       //折算率【Conversion Rate】                                    
                    model.TH072 = "##########";      //库位【Bin】                                                  
                    model.TH073 = "";      //交货时段【Delivery Period】                                  
                    model.TH074 = "";      //预留字段【Reserved Field】                                   
                    model.TH075 = "";      //预留字段【Reserved Field】                                   
                    model.TH076 = "";      //预留字段【Reserved Field】                                   
                    model.TH077 = 0;       //预留字段【Reserved Field】                                   
                    model.TH078 = 0;       //预留字段【Reserved Field】                                   
                    model.TH079 = 0;       //赠备品验收包装量【Largess/Standby Accepted Packing Quantity】
                    model.TH080 = "N";      //暂估码【Indicatively code】                                  
                    model.THC01 = 0;       //赠备品验收数量【Largess/Standby Accepted Quantity】          
                    model.THC02 = "2";      //类型【Type】                                                 
                    model.THC03 = "";      //到货单别【Purchase Arrival Type】                            
                    model.THC04 = "";      //到货单号【Purchase Arrival NO.】                             
                    model.THC05 = "";      //到货序号【Purchase Arrival Sequence】                        
                    model.THC06 = "";      //检验批次【Inspection Batch】                                 
                    model.THC07 = "";    //次数【Times】                                                
                    purths.Add(model);
                }
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("msg", "ok");
                dic.Add("db", purtg.TG001);
                dic.Add("dh", purtg.TG002);
                string result = Common.JsonHelper.ObjToJson(dic);
                try
                {
                    bool result_a = BLL.PURTG.Current.Insert(purtg);
                    bool result_b = BLL.PURTH.Current.Insert(purths);
                    if (result_a && result_b)
                    {
                        context.Response.Write(result);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            #endregion

            else if (context.Request.Params["action"] == "GetSinglePurtcd") {

                var db = context.Request.Params["db"];
                var dh = context.Request.Params["dh"];
                string strjson = BLL.PURTC.Current.GetPurJson(db, dh);
                context.Response.Write(strjson);
                context.Response.End();
            }
        }







        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}