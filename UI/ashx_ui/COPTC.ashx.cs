using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace YJUI.UI.ashx_ui
{
    /// <summary>
    /// COPTC 的摘要说明
    /// </summary>
    public class COPTC : IHttpHandler, IRequiresSessionState
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
                var strjson = new BLL.COPTC().GetListToJson(strWhere, "", (pageindex - 1) * pagesize, pageindex * pagesize);
                context.Response.Write(strjson);
            }
            else if (context.Request.Params["action"] == "add_order")
            {
                BLL.COPTD BllCoptd = new BLL.COPTD();
                var db = context.Request.Params["TC001"];
                var dh = context.Request.Params["TC002"];
                var odb = context.Request.Params["TG001"];//选择销货单别
                //获取订单单头和单身
                Model.COPTC CoptcModel = new BLL.COPTC().CoptcModel(db, dh);//订单单头
                IEnumerable<Model.COPTD> coptds = BllCoptd.GetCOPTDs(db, dh);//订单单身
                Model.COPMA copma = new BLL.COPMA().GetCopmaSingle(CoptcModel.TC004);
                //生成销货单单头
                Model.COPTG CoptgModel = new Model.COPTG();

                CoptgModel.TG001 = odb;//单别【Order Type】                    
                CoptgModel.TG002 = new BLL.COPTG().GetCoptgErpNo(odb);//单号【Order No.】                     
                CoptgModel.TG003 = "";//销货日期【Delivery Date】             
                CoptgModel.TG004 = CoptcModel.TC004;//客户编号【Customer】                  
                CoptgModel.TG005 = CoptcModel.TC005;//部门【Department】                    
                CoptgModel.TG006 = CoptcModel.TC006;//业务员【Sales】                       
                CoptgModel.TG007 = "";//保留字段【Reserved Field】            
                CoptgModel.TG008 = CoptcModel.TC010;//送货地址一【Delivery Address 1】      
                CoptgModel.TG009 = CoptcModel.TC011;//送货地址二【Ship - to Address 2】       
                CoptgModel.TG010 = CoptcModel.TC007;//出货工厂【Delivery Plant】            
                CoptgModel.TG011 = CoptcModel.TC008;//币种【Currency】                      
                CoptgModel.TG012 = CoptcModel.TC009; ;//汇率【Exchange Rate】                 
                CoptgModel.TG013 = CoptcModel.TC029;//原币销货金额【Delivery Amount(O/ C)】  
                CoptgModel.TG014 = "";//预留字段【Invoice Serial Number】     
                CoptgModel.TG015 = "";//预留字段【Tax Register No.】          
                CoptgModel.TG016 = "";//发票种类【Invoice Kind】              
                CoptgModel.TG017 = "";//税种【Tax Type】                      
                CoptgModel.TG018 = "";//预留字段【Invoice Address 1】         
                CoptgModel.TG019 = "";//预留字段【Invoice Address】           
                CoptgModel.TG020 = CoptcModel.TC015;//备注【Remark】                        
                CoptgModel.TG021 = "";//预留字段【Invoice Date】              
                CoptgModel.TG022 = 0;//打印次数【Print Times】               
                CoptgModel.TG023 = "N";//审核码【Approval Indicator】          
                CoptgModel.TG024 = "N";//更新码【Update Indicator】            
                CoptgModel.TG025 = 0;//原币销货税额【Delivery Tax Amount(O / C)
                CoptgModel.TG026 = copma.MA085;//收款业务员【Receiver】                
                CoptgModel.TG027 = "";//备注一【Remark 1】                    
                CoptgModel.TG028 = "";//备注二【Remark 2】                    
                CoptgModel.TG029 = "";//备注三【Remark 3】                    
                CoptgModel.TG030 = "";//预留字段【Invoice Canceled】          
                CoptgModel.TG031 = "N";//烟酒注记【Cigarette & Liquor Remark】 
                CoptgModel.TG032 = 0;//件数【Pieces】                        
                CoptgModel.TG033 = CoptcModel.TC031; ;//总数量【Total Quantity】              
                CoptgModel.TG034 = "";//现销【Cash Sale】                     
                CoptgModel.TG035 = "";//员工编号【Staff】                     
                CoptgModel.TG036 = "N";//生成分录(收入)【Journalized(Revenue)】
                CoptgModel.TG037 = "N";//生成分录(成本)【Journalized(Cost)】   
                CoptgModel.TG038 = "";//申报年月【Declared Year/ Month】       
                CoptgModel.TG039 = "";//L / C_NO【L / C_NO】                      
                CoptgModel.TG040 = "";//INVOICE_NO【INVOICE_NO】              
                CoptgModel.TG041 = 0;//预留字段【Invoice Print Times】       
                CoptgModel.TG042 = DateTime.Now.ToString("yyyyMMdd");//单据日期【Document Date】             
                CoptgModel.TG043 = "";//审核者【Approver】                    
                CoptgModel.TG044 = 0;//税率【Tax Rate】                      
                CoptgModel.TG045 = CoptcModel.TCI03;//本币销货金额【Delivered Amount(B/ C)】 
                CoptgModel.TG046 = 0;//本币销货税额【Delivered Tax(B/ C)】    
                CoptgModel.TG047 = copma.MA083;//付款条件编号【Payment Term】          
                CoptgModel.TG048 = "";//预留字段【Order Type】                
                CoptgModel.TG049 = "";//预留字段【Sales Order Number】        
                CoptgModel.TG050 = "";//预留字段【Received For Arrival Type】 
                CoptgModel.TG051 = "";//预留字段【Received For Arrival No.】  
                CoptgModel.TG052 = 0;//预留字段【Contra Amount】             
                CoptgModel.TG053 = 0;//预留字段【Contra Tax】                
                CoptgModel.TG054 = 0;//总包装数量【Total Packing Quantity】  
                CoptgModel.TG055 = "N";//签核状态码【E - Approval Status】       
                CoptgModel.TG056 = "";//更换发票码【Change Invoice Code】     
                CoptgModel.TG057 = "";//新销货单别【New Sales Delivery Type】 
                CoptgModel.TG058 = "";//新销货单号【New Sales Delivery No.】  
                CoptgModel.TG059 = "N";//抛转状态【Post Status】               
                CoptgModel.TG060 = "";//流程编号【Flow】                      
                CoptgModel.TG061 = "";//预留字段【Invoice with Goods】        
                CoptgModel.TG064 = "";//预留字段【Invoice By】                
                CoptgModel.TG065 = "";//预留字段【Invoice】                   
                CoptgModel.TG066 = "";//海关手册【Customs Handbook】          
                CoptgModel.TG067 = 0;//传送次数【Transfer Times】            
                CoptgModel.TG068 = "N";//EBC汇出码【EBCExport Indicator】      
                CoptgModel.TG069 = "";//预留字段【Reserved Field】            
                CoptgModel.TG070 = "";//预留字段【Reserved Field】            
                CoptgModel.TG071 = 0;//预留字段【Reserved Field】            
                CoptgModel.TG072 = 0;//预留字段【Reserved Field】            
                CoptgModel.TG073 = 0;//预留字段【Reserved Field】            
                CoptgModel.TG074 = "N";//超限放行【Unlimited release】         
                CoptgModel.TG075 = "";//项目编号【Project No.】
                List<Model.COPTH> CopthList = new List<Model.COPTH>();//用于存取销货单单身数据
                //生产销货单单身
                foreach (var item in coptds)
                {
                    Model.COPTH copth = new Model.COPTH();
                    copth.TH001 = CoptgModel.TG001;   //  单别【Order Type】                                         
                    copth.TH002 = CoptgModel.TG002;   //  单号【Order No.】                                          
                    copth.TH003 = item.TD003;   //  序号【Sequence Number】                                    
                    copth.TH004 = item.TD004;   //  品号【Item】                                               
                    copth.TH005 = item.TD005;   //  品名【Item Description】                                   
                    copth.TH006 = item.TD006;   //  规格【Specification】                                      
                    copth.TH007 = item.TD007;   //  仓库【Warehouse】                                          
                    copth.TH008 = item.TD008;   //  数量【Quantity】                                           
                    copth.TH009 = item.TD010;   //  单位【Unit】                                               
                    copth.TH010 = 0;   //  库存数量【Inventory Quantity】                             
                    copth.TH011 = item.TD023;   //  小单位【Small Unit】                                       
                    copth.TH012 = item.TD011;   //  单价【Price】                                              
                    copth.TH013 = item.TD012;   //  金额【Amount】                                             
                    copth.TH014 = item.TD001;   //订单单别【Order Type】                                     
                    copth.TH015 = item.TD002;   //订单单号【Sales Order Number】                             
                    copth.TH016 = item.TD003;   //订单序号【Order Sequence】                                 
                    copth.TH017 = "********************";   //  批号【Lot】                                                
                    copth.TH018 = item.TD020;   //  备注【Remark】                                             
                    copth.TH019 = "";   //  客户品号【Customer Item】                                  
                    copth.TH020 = "N";   //  审核码【Approval Indicator】                               
                    copth.TH021 = "N";   //  更新码【Update Indicator】                                 
                    copth.TH022 = "";   //  保留字段【Reserved Field】                                 
                    copth.TH023 = "";   //  保留字段【Reserved Field】                                 
                    copth.TH024 = 0;   //  赠 / 备品量【Largess / Standby Quantity】                      
                    copth.TH025 = 1;   //  折扣率【Discount Rate】                                    
                    copth.TH026 = "N";   //  开票码【Code bill】                                        
                    copth.TH027 = "";   //  销售发票单别【Order Type】                                 
                    copth.TH028 = "";   //  销售发票单号【Order No.】                                  
                    copth.TH029 = "";   //  销售发票序号【Sales Invoice Sequence】                     
                    copth.TH030 = "";   //  项目编号【Project No.】                                   
                    copth.TH031 = "1";   //  类型【Type】   不可空白.类型分为两种:1.赠品量,2.备品量.                                            
                    copth.TH032 = "";   //  借出单别【Loan Order Type】                                
                    copth.TH033 = "";   //  借出单号【Loan Order Number】                              
                    copth.TH034 = "";   //  借出序号【Loan Order Sequence】                            
                    copth.TH035 = 0;   //  原币税前金额【Amount Un-include Tax of Original Currency】 
                    copth.TH036 = 0;   //  原币税额【Tax of Original Currency】                       
                    copth.TH037 = 0;   //  本币税前金额【Amount Un-include Tax of Base Currency】     
                    copth.TH038 = 0;   //  本币税额【Tax of Base Currency】                           
                    copth.TH039 = 0;   //  包装数量【Packing Quantity】                               
                    copth.TH040 = 0;   //  赠 / 备品包装量【Largess / Standby Packing Quantity】          
                    copth.TH041 = item.TD036;   //  包装单位【Packing Unit】                                   
                    copth.TH042 = 0;   //  已开票数量【Has argued that the number of】                
                    copth.TH043 = 0;   //  件装【Pieces Per】                                         
                    copth.TH044 = 0;   //  件数【Pieces】                                             
                    copth.TH045 = "";   //  出货通知单别【Delivery Notice Type】                       
                    copth.TH046 = "";   //  出货通知单号【Delivery Notice Number】                     
                    copth.TH047 = "";   //  出货通知序号【Delivery Notice Sequence】                   
                    copth.TH048 = 0;   //  税率【Reserved Field】                                     
                    copth.TH049 = 0;   //  批发价【Wholesale Price】                                  
                    copth.TH050 = 0;   //  零售价【Retail Price】                                     
                    copth.TH051 = "";   //  生产日期【Production Date】                                
                    copth.TH052 = "";   //  有效日期【Effective Date】                                 
                    copth.TH053 = "";   //  复检日期【Reinsepction Date】                              
                    copth.TH054 = "";   //  原始客户【Original Customer】                              
                    copth.TH055 = "";   //  批号说明【Lot Description】                                
                    copth.TH056 = "##########";   //  库位【Bin】                                                
                    copth.TH057 = "";   //  预留字段【Reserved Field】                                 
                    copth.TH058 = "";   //  预留字段【Reserved Field】                                 
                    copth.TH059 = "";   //  预留字段【Reserved Field】                                 
                    copth.TH060 = 0;   //  预留字段【Reserved Field】                                 
                    copth.TH061 = 0;   //  预留字段【Reserved Field】                                 
                    copth.TH062 = 0;   //  预留字段【Reserved Field】                                 
                    copth.THD01 = 0;   //  安装调试数量【Installation Quantity】                      
                    copth.TH063 = "";   //  分期期别【Installment Stage】                              
                    copth.TH064 = "N";   //  分期合同【Installment Contract】                           
                    copth.TH065 = "";   //  分期单别【Installment Source Type】                        
                    copth.TH066 = "";   //  分期单号【Installment Source No.】                         
                    copth.THH01 = "N";   //  检核确认【Confirmed】       
                    CopthList.Add(copth);//每条记录保存到list里面
                }

            }
            else if (context.Request.Params["action"] == "getSingleCoptc") {

                var tc001 = context.Request.Params["tc001"];
                var tc002 = context.Request.Params["tc002"];
                Model.COPTC coptc = BLL.COPTC.Current.CoptcModel(tc001,tc002);
                IEnumerable<Model.COPTD> coptd = BLL.COPTD.Current.GetCOPTDs(tc001, tc002);

                var qty = coptd.Sum(t=>t.TD008);
                var amount = coptd.Sum(t => t.TD012);



                List<Dictionary<string, object>> l = new List<Dictionary<string, object>>();
                Dictionary<string, object> d = new Dictionary<string, object>();
                d.Add("TD003", "合计");
                d.Add("TD008", qty);
                d.Add("TD012", amount);
                l.Add(d);
                //foot结束
                Dictionary<string, object> dic = new Dictionary<string, object>();
                dic.Add("rows", coptd);
                dic.Add("footer", l);


                Dictionary<string, object> d2 = new Dictionary<string, object>();
                d2.Add("coptc", coptc);
                d2.Add("coptd", dic);

                string strjson = Common.JsonHelper.ObjToJson(d2);
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