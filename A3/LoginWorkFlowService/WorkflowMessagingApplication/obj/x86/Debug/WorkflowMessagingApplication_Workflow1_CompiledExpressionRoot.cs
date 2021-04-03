namespace WorkflowMessagingApplication {
    
    #line 23 "S:\GitHub\CSE 446\A3\LoginWorkFlowService\WorkflowMessagingApplication\Workflow1.xaml"
    using System;
    
    #line default
    #line hidden
    
    #line 1 "S:\GitHub\CSE 446\A3\LoginWorkFlowService\WorkflowMessagingApplication\Workflow1.xaml"
    using System.Collections;
    
    #line default
    #line hidden
    
    #line 24 "S:\GitHub\CSE 446\A3\LoginWorkFlowService\WorkflowMessagingApplication\Workflow1.xaml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 1 "S:\GitHub\CSE 446\A3\LoginWorkFlowService\WorkflowMessagingApplication\Workflow1.xaml"
    using System.Activities;
    
    #line default
    #line hidden
    
    #line 1 "S:\GitHub\CSE 446\A3\LoginWorkFlowService\WorkflowMessagingApplication\Workflow1.xaml"
    using System.Activities.Expressions;
    
    #line default
    #line hidden
    
    #line 1 "S:\GitHub\CSE 446\A3\LoginWorkFlowService\WorkflowMessagingApplication\Workflow1.xaml"
    using System.Activities.Statements;
    
    #line default
    #line hidden
    
    #line 25 "S:\GitHub\CSE 446\A3\LoginWorkFlowService\WorkflowMessagingApplication\Workflow1.xaml"
    using System.Data;
    
    #line default
    #line hidden
    
    #line 26 "S:\GitHub\CSE 446\A3\LoginWorkFlowService\WorkflowMessagingApplication\Workflow1.xaml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 27 "S:\GitHub\CSE 446\A3\LoginWorkFlowService\WorkflowMessagingApplication\Workflow1.xaml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 1 "S:\GitHub\CSE 446\A3\LoginWorkFlowService\WorkflowMessagingApplication\Workflow1.xaml"
    using System.Activities.XamlIntegration;
    
    #line default
    #line hidden
    
    
    public partial class Workflow1 : System.Activities.XamlIntegration.ICompiledExpressionRoot {
        
        private System.Activities.Activity rootActivity;
        
        private object dataContextActivities;
        
        private bool forImplementation = true;
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public string GetLanguage() {
            return "C#";
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((this.dataContextActivities == null)) {
                this.dataContextActivities = Workflow1_TypedDataContext2_ForReadOnly.GetDataContextActivitiesHelper(this.rootActivity, this.forImplementation);
            }
            if ((expressionId == 0)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext2_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[0] == null)) {
                    cachedCompiledDataContext[0] = new Workflow1_TypedDataContext2_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext2_ForReadOnly valDataContext0 = ((Workflow1_TypedDataContext2_ForReadOnly)(cachedCompiledDataContext[0]));
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext1 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext3(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3 refDataContext2 = ((Workflow1_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext2.GetLocation<string>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 3)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[1] == null)) {
                    cachedCompiledDataContext[1] = new Workflow1_TypedDataContext3_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3_ForReadOnly valDataContext3 = ((Workflow1_TypedDataContext3_ForReadOnly)(cachedCompiledDataContext[1]));
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext3(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3 refDataContext4 = ((Workflow1_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext4.GetLocation<string>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 5)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext3.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[2] == null)) {
                    cachedCompiledDataContext[2] = new Workflow1_TypedDataContext3(locations, activityContext, true);
                }
                Workflow1_TypedDataContext3 refDataContext5 = ((Workflow1_TypedDataContext3)(cachedCompiledDataContext[2]));
                return refDataContext5.GetLocation<string>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 6)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext6 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow1_TypedDataContext4(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4 refDataContext7 = ((Workflow1_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 8)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext8 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow1_TypedDataContext4(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4 refDataContext9 = ((Workflow1_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 10)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow1_TypedDataContext4(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4 refDataContext10 = ((Workflow1_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext10.GetLocation<bool>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 11)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext11 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext12 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[3] == null)) {
                    cachedCompiledDataContext[3] = new Workflow1_TypedDataContext4_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4_ForReadOnly valDataContext13 = ((Workflow1_TypedDataContext4_ForReadOnly)(cachedCompiledDataContext[3]));
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext4.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[4] == null)) {
                    cachedCompiledDataContext[4] = new Workflow1_TypedDataContext4(locations, activityContext, true);
                }
                Workflow1_TypedDataContext4 refDataContext14 = ((Workflow1_TypedDataContext4)(cachedCompiledDataContext[4]));
                return refDataContext14.GetLocation<string>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 15)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext15 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext16 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext16.GetLocation<string>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 17)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext17 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext18 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext18.GetLocation<string>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 19)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext19 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext19.GetLocation<bool>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 20)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext20 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext21 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext22 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[5] == null)) {
                    cachedCompiledDataContext[5] = new Workflow1_TypedDataContext5_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5_ForReadOnly valDataContext23 = ((Workflow1_TypedDataContext5_ForReadOnly)(cachedCompiledDataContext[5]));
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext24 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext24.GetLocation<string>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 25)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext5.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[6] == null)) {
                    cachedCompiledDataContext[6] = new Workflow1_TypedDataContext5(locations, activityContext, true);
                }
                Workflow1_TypedDataContext5 refDataContext25 = ((Workflow1_TypedDataContext5)(cachedCompiledDataContext[6]));
                return refDataContext25.GetLocation<string>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 26)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6_ForReadOnly valDataContext26 = ((Workflow1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow1_TypedDataContext6(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6 refDataContext27 = ((Workflow1_TypedDataContext6)(cachedCompiledDataContext[8]));
                return refDataContext27.GetLocation<string>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 28)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[7] == null)) {
                    cachedCompiledDataContext[7] = new Workflow1_TypedDataContext6_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6_ForReadOnly valDataContext28 = ((Workflow1_TypedDataContext6_ForReadOnly)(cachedCompiledDataContext[7]));
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow1_TypedDataContext6(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6 refDataContext29 = ((Workflow1_TypedDataContext6)(cachedCompiledDataContext[8]));
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 30)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow1_TypedDataContext6(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6 refDataContext30 = ((Workflow1_TypedDataContext6)(cachedCompiledDataContext[8]));
                return refDataContext30.GetLocation<string>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 31)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow1_TypedDataContext6(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6 refDataContext31 = ((Workflow1_TypedDataContext6)(cachedCompiledDataContext[8]));
                return refDataContext31.GetLocation<string>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 32)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext6.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[8] == null)) {
                    cachedCompiledDataContext[8] = new Workflow1_TypedDataContext6(locations, activityContext, true);
                }
                Workflow1_TypedDataContext6 refDataContext32 = ((Workflow1_TypedDataContext6)(cachedCompiledDataContext[8]));
                return refDataContext32.GetLocation<string>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 33)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext7_ForReadOnly valDataContext33 = ((Workflow1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow1_TypedDataContext7(locations, activityContext, true);
                }
                Workflow1_TypedDataContext7 refDataContext34 = ((Workflow1_TypedDataContext7)(cachedCompiledDataContext[10]));
                return refDataContext34.GetLocation<string>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 35)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow1_TypedDataContext7(locations, activityContext, true);
                }
                Workflow1_TypedDataContext7 refDataContext35 = ((Workflow1_TypedDataContext7)(cachedCompiledDataContext[10]));
                return refDataContext35.GetLocation<string>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 36)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext7_ForReadOnly valDataContext36 = ((Workflow1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext7_ForReadOnly valDataContext37 = ((Workflow1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow1_TypedDataContext7(locations, activityContext, true);
                }
                Workflow1_TypedDataContext7 refDataContext38 = ((Workflow1_TypedDataContext7)(cachedCompiledDataContext[10]));
                return refDataContext38.GetLocation<string>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 39)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext7_ForReadOnly valDataContext39 = ((Workflow1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext7_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[9] == null)) {
                    cachedCompiledDataContext[9] = new Workflow1_TypedDataContext7_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext7_ForReadOnly valDataContext40 = ((Workflow1_TypedDataContext7_ForReadOnly)(cachedCompiledDataContext[9]));
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext7.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[10] == null)) {
                    cachedCompiledDataContext[10] = new Workflow1_TypedDataContext7(locations, activityContext, true);
                }
                Workflow1_TypedDataContext7 refDataContext41 = ((Workflow1_TypedDataContext7)(cachedCompiledDataContext[10]));
                return refDataContext41.GetLocation<string>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 42)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow1_TypedDataContext8(locations, activityContext, true);
                }
                Workflow1_TypedDataContext8 refDataContext42 = ((Workflow1_TypedDataContext8)(cachedCompiledDataContext[11]));
                return refDataContext42.GetLocation<string>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 43)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Workflow1_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext8_ForReadOnly valDataContext43 = ((Workflow1_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext8_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[12] == null)) {
                    cachedCompiledDataContext[12] = new Workflow1_TypedDataContext8_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext8_ForReadOnly valDataContext44 = ((Workflow1_TypedDataContext8_ForReadOnly)(cachedCompiledDataContext[12]));
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext8.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[11] == null)) {
                    cachedCompiledDataContext[11] = new Workflow1_TypedDataContext8(locations, activityContext, true);
                }
                Workflow1_TypedDataContext8 refDataContext45 = ((Workflow1_TypedDataContext8)(cachedCompiledDataContext[11]));
                return refDataContext45.GetLocation<string>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 46)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Workflow1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext9_ForReadOnly valDataContext46 = ((Workflow1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Workflow1_TypedDataContext9(locations, activityContext, true);
                }
                Workflow1_TypedDataContext9 refDataContext47 = ((Workflow1_TypedDataContext9)(cachedCompiledDataContext[14]));
                return refDataContext47.GetLocation<string>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set, expressionId, this.rootActivity, activityContext);
            }
            if ((expressionId == 48)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Workflow1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext9_ForReadOnly valDataContext48 = ((Workflow1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext9_ForReadOnly.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[13] == null)) {
                    cachedCompiledDataContext[13] = new Workflow1_TypedDataContext9_ForReadOnly(locations, activityContext, true);
                }
                Workflow1_TypedDataContext9_ForReadOnly valDataContext49 = ((Workflow1_TypedDataContext9_ForReadOnly)(cachedCompiledDataContext[13]));
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                System.Activities.XamlIntegration.CompiledDataContext[] cachedCompiledDataContext = Workflow1_TypedDataContext9.GetCompiledDataContextCacheHelper(this.dataContextActivities, activityContext, this.rootActivity, this.forImplementation, 15);
                if ((cachedCompiledDataContext[14] == null)) {
                    cachedCompiledDataContext[14] = new Workflow1_TypedDataContext9(locations, activityContext, true);
                }
                Workflow1_TypedDataContext9 refDataContext50 = ((Workflow1_TypedDataContext9)(cachedCompiledDataContext[14]));
                return refDataContext50.GetLocation<string>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set, expressionId, this.rootActivity, activityContext);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public object InvokeExpression(int expressionId, System.Collections.Generic.IList<System.Activities.Location> locations) {
            if ((this.rootActivity == null)) {
                this.rootActivity = this;
            }
            if ((expressionId == 0)) {
                Workflow1_TypedDataContext2_ForReadOnly valDataContext0 = new Workflow1_TypedDataContext2_ForReadOnly(locations, true);
                return valDataContext0.ValueType___Expr0Get();
            }
            if ((expressionId == 1)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext1 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext1.ValueType___Expr1Get();
            }
            if ((expressionId == 2)) {
                Workflow1_TypedDataContext3 refDataContext2 = new Workflow1_TypedDataContext3(locations, true);
                return refDataContext2.GetLocation<string>(refDataContext2.ValueType___Expr2Get, refDataContext2.ValueType___Expr2Set);
            }
            if ((expressionId == 3)) {
                Workflow1_TypedDataContext3_ForReadOnly valDataContext3 = new Workflow1_TypedDataContext3_ForReadOnly(locations, true);
                return valDataContext3.ValueType___Expr3Get();
            }
            if ((expressionId == 4)) {
                Workflow1_TypedDataContext3 refDataContext4 = new Workflow1_TypedDataContext3(locations, true);
                return refDataContext4.GetLocation<string>(refDataContext4.ValueType___Expr4Get, refDataContext4.ValueType___Expr4Set);
            }
            if ((expressionId == 5)) {
                Workflow1_TypedDataContext3 refDataContext5 = new Workflow1_TypedDataContext3(locations, true);
                return refDataContext5.GetLocation<string>(refDataContext5.ValueType___Expr5Get, refDataContext5.ValueType___Expr5Set);
            }
            if ((expressionId == 6)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext6 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext6.ValueType___Expr6Get();
            }
            if ((expressionId == 7)) {
                Workflow1_TypedDataContext4 refDataContext7 = new Workflow1_TypedDataContext4(locations, true);
                return refDataContext7.GetLocation<string>(refDataContext7.ValueType___Expr7Get, refDataContext7.ValueType___Expr7Set);
            }
            if ((expressionId == 8)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext8 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext8.ValueType___Expr8Get();
            }
            if ((expressionId == 9)) {
                Workflow1_TypedDataContext4 refDataContext9 = new Workflow1_TypedDataContext4(locations, true);
                return refDataContext9.GetLocation<string>(refDataContext9.ValueType___Expr9Get, refDataContext9.ValueType___Expr9Set);
            }
            if ((expressionId == 10)) {
                Workflow1_TypedDataContext4 refDataContext10 = new Workflow1_TypedDataContext4(locations, true);
                return refDataContext10.GetLocation<bool>(refDataContext10.ValueType___Expr10Get, refDataContext10.ValueType___Expr10Set);
            }
            if ((expressionId == 11)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext11 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext11.ValueType___Expr11Get();
            }
            if ((expressionId == 12)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext12 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext12.ValueType___Expr12Get();
            }
            if ((expressionId == 13)) {
                Workflow1_TypedDataContext4_ForReadOnly valDataContext13 = new Workflow1_TypedDataContext4_ForReadOnly(locations, true);
                return valDataContext13.ValueType___Expr13Get();
            }
            if ((expressionId == 14)) {
                Workflow1_TypedDataContext4 refDataContext14 = new Workflow1_TypedDataContext4(locations, true);
                return refDataContext14.GetLocation<string>(refDataContext14.ValueType___Expr14Get, refDataContext14.ValueType___Expr14Set);
            }
            if ((expressionId == 15)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext15 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext15.ValueType___Expr15Get();
            }
            if ((expressionId == 16)) {
                Workflow1_TypedDataContext5 refDataContext16 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext16.GetLocation<string>(refDataContext16.ValueType___Expr16Get, refDataContext16.ValueType___Expr16Set);
            }
            if ((expressionId == 17)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext17 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext17.ValueType___Expr17Get();
            }
            if ((expressionId == 18)) {
                Workflow1_TypedDataContext5 refDataContext18 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext18.GetLocation<string>(refDataContext18.ValueType___Expr18Get, refDataContext18.ValueType___Expr18Set);
            }
            if ((expressionId == 19)) {
                Workflow1_TypedDataContext5 refDataContext19 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext19.GetLocation<bool>(refDataContext19.ValueType___Expr19Get, refDataContext19.ValueType___Expr19Set);
            }
            if ((expressionId == 20)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext20 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext20.ValueType___Expr20Get();
            }
            if ((expressionId == 21)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext21 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext21.ValueType___Expr21Get();
            }
            if ((expressionId == 22)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext22 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext22.ValueType___Expr22Get();
            }
            if ((expressionId == 23)) {
                Workflow1_TypedDataContext5_ForReadOnly valDataContext23 = new Workflow1_TypedDataContext5_ForReadOnly(locations, true);
                return valDataContext23.ValueType___Expr23Get();
            }
            if ((expressionId == 24)) {
                Workflow1_TypedDataContext5 refDataContext24 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext24.GetLocation<string>(refDataContext24.ValueType___Expr24Get, refDataContext24.ValueType___Expr24Set);
            }
            if ((expressionId == 25)) {
                Workflow1_TypedDataContext5 refDataContext25 = new Workflow1_TypedDataContext5(locations, true);
                return refDataContext25.GetLocation<string>(refDataContext25.ValueType___Expr25Get, refDataContext25.ValueType___Expr25Set);
            }
            if ((expressionId == 26)) {
                Workflow1_TypedDataContext6_ForReadOnly valDataContext26 = new Workflow1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext26.ValueType___Expr26Get();
            }
            if ((expressionId == 27)) {
                Workflow1_TypedDataContext6 refDataContext27 = new Workflow1_TypedDataContext6(locations, true);
                return refDataContext27.GetLocation<string>(refDataContext27.ValueType___Expr27Get, refDataContext27.ValueType___Expr27Set);
            }
            if ((expressionId == 28)) {
                Workflow1_TypedDataContext6_ForReadOnly valDataContext28 = new Workflow1_TypedDataContext6_ForReadOnly(locations, true);
                return valDataContext28.ValueType___Expr28Get();
            }
            if ((expressionId == 29)) {
                Workflow1_TypedDataContext6 refDataContext29 = new Workflow1_TypedDataContext6(locations, true);
                return refDataContext29.GetLocation<string>(refDataContext29.ValueType___Expr29Get, refDataContext29.ValueType___Expr29Set);
            }
            if ((expressionId == 30)) {
                Workflow1_TypedDataContext6 refDataContext30 = new Workflow1_TypedDataContext6(locations, true);
                return refDataContext30.GetLocation<string>(refDataContext30.ValueType___Expr30Get, refDataContext30.ValueType___Expr30Set);
            }
            if ((expressionId == 31)) {
                Workflow1_TypedDataContext6 refDataContext31 = new Workflow1_TypedDataContext6(locations, true);
                return refDataContext31.GetLocation<string>(refDataContext31.ValueType___Expr31Get, refDataContext31.ValueType___Expr31Set);
            }
            if ((expressionId == 32)) {
                Workflow1_TypedDataContext6 refDataContext32 = new Workflow1_TypedDataContext6(locations, true);
                return refDataContext32.GetLocation<string>(refDataContext32.ValueType___Expr32Get, refDataContext32.ValueType___Expr32Set);
            }
            if ((expressionId == 33)) {
                Workflow1_TypedDataContext7_ForReadOnly valDataContext33 = new Workflow1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext33.ValueType___Expr33Get();
            }
            if ((expressionId == 34)) {
                Workflow1_TypedDataContext7 refDataContext34 = new Workflow1_TypedDataContext7(locations, true);
                return refDataContext34.GetLocation<string>(refDataContext34.ValueType___Expr34Get, refDataContext34.ValueType___Expr34Set);
            }
            if ((expressionId == 35)) {
                Workflow1_TypedDataContext7 refDataContext35 = new Workflow1_TypedDataContext7(locations, true);
                return refDataContext35.GetLocation<string>(refDataContext35.ValueType___Expr35Get, refDataContext35.ValueType___Expr35Set);
            }
            if ((expressionId == 36)) {
                Workflow1_TypedDataContext7_ForReadOnly valDataContext36 = new Workflow1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext36.ValueType___Expr36Get();
            }
            if ((expressionId == 37)) {
                Workflow1_TypedDataContext7_ForReadOnly valDataContext37 = new Workflow1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext37.ValueType___Expr37Get();
            }
            if ((expressionId == 38)) {
                Workflow1_TypedDataContext7 refDataContext38 = new Workflow1_TypedDataContext7(locations, true);
                return refDataContext38.GetLocation<string>(refDataContext38.ValueType___Expr38Get, refDataContext38.ValueType___Expr38Set);
            }
            if ((expressionId == 39)) {
                Workflow1_TypedDataContext7_ForReadOnly valDataContext39 = new Workflow1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext39.ValueType___Expr39Get();
            }
            if ((expressionId == 40)) {
                Workflow1_TypedDataContext7_ForReadOnly valDataContext40 = new Workflow1_TypedDataContext7_ForReadOnly(locations, true);
                return valDataContext40.ValueType___Expr40Get();
            }
            if ((expressionId == 41)) {
                Workflow1_TypedDataContext7 refDataContext41 = new Workflow1_TypedDataContext7(locations, true);
                return refDataContext41.GetLocation<string>(refDataContext41.ValueType___Expr41Get, refDataContext41.ValueType___Expr41Set);
            }
            if ((expressionId == 42)) {
                Workflow1_TypedDataContext8 refDataContext42 = new Workflow1_TypedDataContext8(locations, true);
                return refDataContext42.GetLocation<string>(refDataContext42.ValueType___Expr42Get, refDataContext42.ValueType___Expr42Set);
            }
            if ((expressionId == 43)) {
                Workflow1_TypedDataContext8_ForReadOnly valDataContext43 = new Workflow1_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext43.ValueType___Expr43Get();
            }
            if ((expressionId == 44)) {
                Workflow1_TypedDataContext8_ForReadOnly valDataContext44 = new Workflow1_TypedDataContext8_ForReadOnly(locations, true);
                return valDataContext44.ValueType___Expr44Get();
            }
            if ((expressionId == 45)) {
                Workflow1_TypedDataContext8 refDataContext45 = new Workflow1_TypedDataContext8(locations, true);
                return refDataContext45.GetLocation<string>(refDataContext45.ValueType___Expr45Get, refDataContext45.ValueType___Expr45Set);
            }
            if ((expressionId == 46)) {
                Workflow1_TypedDataContext9_ForReadOnly valDataContext46 = new Workflow1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext46.ValueType___Expr46Get();
            }
            if ((expressionId == 47)) {
                Workflow1_TypedDataContext9 refDataContext47 = new Workflow1_TypedDataContext9(locations, true);
                return refDataContext47.GetLocation<string>(refDataContext47.ValueType___Expr47Get, refDataContext47.ValueType___Expr47Set);
            }
            if ((expressionId == 48)) {
                Workflow1_TypedDataContext9_ForReadOnly valDataContext48 = new Workflow1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext48.ValueType___Expr48Get();
            }
            if ((expressionId == 49)) {
                Workflow1_TypedDataContext9_ForReadOnly valDataContext49 = new Workflow1_TypedDataContext9_ForReadOnly(locations, true);
                return valDataContext49.ValueType___Expr49Get();
            }
            if ((expressionId == 50)) {
                Workflow1_TypedDataContext9 refDataContext50 = new Workflow1_TypedDataContext9(locations, true);
                return refDataContext50.GetLocation<string>(refDataContext50.ValueType___Expr50Get, refDataContext50.ValueType___Expr50Set);
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CanExecuteExpression(string expressionText, bool isReference, System.Collections.Generic.IList<System.Activities.LocationReference> locations, out int expressionId) {
            if (((isReference == false) 
                        && ((expressionText == "currentState") 
                        && (Workflow1_TypedDataContext2_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 0;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 1;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "selection") 
                        && (Workflow1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 2;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "selection.ToUpper()") 
                        && (Workflow1_TypedDataContext3_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 3;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentState") 
                        && (Workflow1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 4;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentState") 
                        && (Workflow1_TypedDataContext3.Validate(locations, true, 0) == true)))) {
                expressionId = 5;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 6;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "userName") 
                        && (Workflow1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 7;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 8;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "password") 
                        && (Workflow1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 9;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "wasUserCreated") 
                        && (Workflow1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 10;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "password") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 11;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "userName") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 12;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "wasUserCreated") 
                        && (Workflow1_TypedDataContext4_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 13;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentState") 
                        && (Workflow1_TypedDataContext4.Validate(locations, true, 0) == true)))) {
                expressionId = 14;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 15;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "userName") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 16;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 17;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "password") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 18;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "wasSuccessfullLogin") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 19;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "userName") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 20;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "password") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 21;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "wasSuccessfullLogin") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 22;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "userName") 
                        && (Workflow1_TypedDataContext5_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 23;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "useId") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 24;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentState") 
                        && (Workflow1_TypedDataContext5.Validate(locations, true, 0) == true)))) {
                expressionId = 25;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 26;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "sendOrReveiveOption") 
                        && (Workflow1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 27;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "sendOrReveiveOption.ToUpper()") 
                        && (Workflow1_TypedDataContext6_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 28;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentState") 
                        && (Workflow1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 29;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentState") 
                        && (Workflow1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 30;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentState") 
                        && (Workflow1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 31;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentState") 
                        && (Workflow1_TypedDataContext6.Validate(locations, true, 0) == true)))) {
                expressionId = 32;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine().Trim()") 
                        && (Workflow1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 33;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "sendUserId") 
                        && (Workflow1_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 34;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "oldMessage") 
                        && (Workflow1_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 35;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "sendUserId") 
                        && (Workflow1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 36;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"From \" + useId + \": \" + Console.ReadLine()  +\", \" + oldMessage") 
                        && (Workflow1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 37;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "message") 
                        && (Workflow1_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 38;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "message") 
                        && (Workflow1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 39;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "sendUserId") 
                        && (Workflow1_TypedDataContext7_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 40;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentState") 
                        && (Workflow1_TypedDataContext7.Validate(locations, true, 0) == true)))) {
                expressionId = 41;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "message") 
                        && (Workflow1_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 42;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "useId") 
                        && (Workflow1_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 43;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "\"Messages: \" + message") 
                        && (Workflow1_TypedDataContext8_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 44;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentState") 
                        && (Workflow1_TypedDataContext8.Validate(locations, true, 0) == true)))) {
                expressionId = 45;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "Console.ReadLine()") 
                        && (Workflow1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 46;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "clear") 
                        && (Workflow1_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 47;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "clear.ToUpper().Trim().Equals(\"Y\")") 
                        && (Workflow1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 48;
                return true;
            }
            if (((isReference == false) 
                        && ((expressionText == "useId") 
                        && (Workflow1_TypedDataContext9_ForReadOnly.Validate(locations, true, 0) == true)))) {
                expressionId = 49;
                return true;
            }
            if (((isReference == true) 
                        && ((expressionText == "currentState") 
                        && (Workflow1_TypedDataContext9.Validate(locations, true, 0) == true)))) {
                expressionId = 50;
                return true;
            }
            expressionId = -1;
            return false;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Collections.Generic.IList<string> GetRequiredLocations(int expressionId) {
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public System.Linq.Expressions.Expression GetExpressionTreeForExpression(int expressionId, System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) {
            if ((expressionId == 0)) {
                return new Workflow1_TypedDataContext2_ForReadOnly(locationReferences).@__Expr0GetTree();
            }
            if ((expressionId == 1)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr1GetTree();
            }
            if ((expressionId == 2)) {
                return new Workflow1_TypedDataContext3(locationReferences).@__Expr2GetTree();
            }
            if ((expressionId == 3)) {
                return new Workflow1_TypedDataContext3_ForReadOnly(locationReferences).@__Expr3GetTree();
            }
            if ((expressionId == 4)) {
                return new Workflow1_TypedDataContext3(locationReferences).@__Expr4GetTree();
            }
            if ((expressionId == 5)) {
                return new Workflow1_TypedDataContext3(locationReferences).@__Expr5GetTree();
            }
            if ((expressionId == 6)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr6GetTree();
            }
            if ((expressionId == 7)) {
                return new Workflow1_TypedDataContext4(locationReferences).@__Expr7GetTree();
            }
            if ((expressionId == 8)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr8GetTree();
            }
            if ((expressionId == 9)) {
                return new Workflow1_TypedDataContext4(locationReferences).@__Expr9GetTree();
            }
            if ((expressionId == 10)) {
                return new Workflow1_TypedDataContext4(locationReferences).@__Expr10GetTree();
            }
            if ((expressionId == 11)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr11GetTree();
            }
            if ((expressionId == 12)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr12GetTree();
            }
            if ((expressionId == 13)) {
                return new Workflow1_TypedDataContext4_ForReadOnly(locationReferences).@__Expr13GetTree();
            }
            if ((expressionId == 14)) {
                return new Workflow1_TypedDataContext4(locationReferences).@__Expr14GetTree();
            }
            if ((expressionId == 15)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr15GetTree();
            }
            if ((expressionId == 16)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr16GetTree();
            }
            if ((expressionId == 17)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr17GetTree();
            }
            if ((expressionId == 18)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr18GetTree();
            }
            if ((expressionId == 19)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr19GetTree();
            }
            if ((expressionId == 20)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr20GetTree();
            }
            if ((expressionId == 21)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr21GetTree();
            }
            if ((expressionId == 22)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr22GetTree();
            }
            if ((expressionId == 23)) {
                return new Workflow1_TypedDataContext5_ForReadOnly(locationReferences).@__Expr23GetTree();
            }
            if ((expressionId == 24)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr24GetTree();
            }
            if ((expressionId == 25)) {
                return new Workflow1_TypedDataContext5(locationReferences).@__Expr25GetTree();
            }
            if ((expressionId == 26)) {
                return new Workflow1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr26GetTree();
            }
            if ((expressionId == 27)) {
                return new Workflow1_TypedDataContext6(locationReferences).@__Expr27GetTree();
            }
            if ((expressionId == 28)) {
                return new Workflow1_TypedDataContext6_ForReadOnly(locationReferences).@__Expr28GetTree();
            }
            if ((expressionId == 29)) {
                return new Workflow1_TypedDataContext6(locationReferences).@__Expr29GetTree();
            }
            if ((expressionId == 30)) {
                return new Workflow1_TypedDataContext6(locationReferences).@__Expr30GetTree();
            }
            if ((expressionId == 31)) {
                return new Workflow1_TypedDataContext6(locationReferences).@__Expr31GetTree();
            }
            if ((expressionId == 32)) {
                return new Workflow1_TypedDataContext6(locationReferences).@__Expr32GetTree();
            }
            if ((expressionId == 33)) {
                return new Workflow1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr33GetTree();
            }
            if ((expressionId == 34)) {
                return new Workflow1_TypedDataContext7(locationReferences).@__Expr34GetTree();
            }
            if ((expressionId == 35)) {
                return new Workflow1_TypedDataContext7(locationReferences).@__Expr35GetTree();
            }
            if ((expressionId == 36)) {
                return new Workflow1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr36GetTree();
            }
            if ((expressionId == 37)) {
                return new Workflow1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr37GetTree();
            }
            if ((expressionId == 38)) {
                return new Workflow1_TypedDataContext7(locationReferences).@__Expr38GetTree();
            }
            if ((expressionId == 39)) {
                return new Workflow1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr39GetTree();
            }
            if ((expressionId == 40)) {
                return new Workflow1_TypedDataContext7_ForReadOnly(locationReferences).@__Expr40GetTree();
            }
            if ((expressionId == 41)) {
                return new Workflow1_TypedDataContext7(locationReferences).@__Expr41GetTree();
            }
            if ((expressionId == 42)) {
                return new Workflow1_TypedDataContext8(locationReferences).@__Expr42GetTree();
            }
            if ((expressionId == 43)) {
                return new Workflow1_TypedDataContext8_ForReadOnly(locationReferences).@__Expr43GetTree();
            }
            if ((expressionId == 44)) {
                return new Workflow1_TypedDataContext8_ForReadOnly(locationReferences).@__Expr44GetTree();
            }
            if ((expressionId == 45)) {
                return new Workflow1_TypedDataContext8(locationReferences).@__Expr45GetTree();
            }
            if ((expressionId == 46)) {
                return new Workflow1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr46GetTree();
            }
            if ((expressionId == 47)) {
                return new Workflow1_TypedDataContext9(locationReferences).@__Expr47GetTree();
            }
            if ((expressionId == 48)) {
                return new Workflow1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr48GetTree();
            }
            if ((expressionId == 49)) {
                return new Workflow1_TypedDataContext9_ForReadOnly(locationReferences).@__Expr49GetTree();
            }
            if ((expressionId == 50)) {
                return new Workflow1_TypedDataContext9(locationReferences).@__Expr50GetTree();
            }
            return null;
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext0 : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext0_ForReadOnly : System.Activities.XamlIntegration.CompiledDataContext {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext0_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal static object GetDataContextActivitiesHelper(System.Activities.Activity compiledRoot, bool forImplementation) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetDataContextActivities(compiledRoot, forImplementation);
            }
            
            internal static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
            }
            
            public static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return true;
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext1 : Workflow1_TypedDataContext0 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow1_TypedDataContext0.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext1_ForReadOnly : Workflow1_TypedDataContext0_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext1_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 0))) {
                    return false;
                }
                expectedLocationsCount = 0;
                return Workflow1_TypedDataContext0_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext2 : Workflow1_TypedDataContext1 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string currentState {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((0 + locationsOffset), value);
                }
            }
            
            protected string useId {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((1 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "currentState") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "useId") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext1.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext2_ForReadOnly : Workflow1_TypedDataContext1_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext2_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string currentState {
                get {
                    return ((string)(this.GetVariableValue((0 + locationsOffset))));
                }
            }
            
            protected string useId {
                get {
                    return ((string)(this.GetVariableValue((1 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr0GetTree() {
                
                #line 56 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
          currentState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr0Get() {
                
                #line 56 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
          currentState;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr0Get() {
                this.GetValueTypeValues();
                return this.@__Expr0Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 2))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 2);
                }
                expectedLocationsCount = 2;
                if (((locationReferences[(offset + 0)].Name != "currentState") 
                            || (locationReferences[(offset + 0)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 1)].Name != "useId") 
                            || (locationReferences[(offset + 1)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext1_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext3 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string selection {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr2GetTree() {
                
                #line 67 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              selection;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr2Get() {
                
                #line 67 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              selection;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr2Get() {
                this.GetValueTypeValues();
                return this.@__Expr2Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr2Set(string value) {
                
                #line 67 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              selection = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr2Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr2Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr4GetTree() {
                
                #line 88 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                currentState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr4Get() {
                
                #line 88 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
                currentState;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr4Get() {
                this.GetValueTypeValues();
                return this.@__Expr4Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr4Set(string value) {
                
                #line 88 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
                currentState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr4Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr4Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr5GetTree() {
                
                #line 98 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                currentState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr5Get() {
                
                #line 98 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
                currentState;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr5Get() {
                this.GetValueTypeValues();
                return this.@__Expr5Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr5Set(string value) {
                
                #line 98 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
                currentState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr5Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr5Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 2)].Name != "selection") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext3_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext3_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string selection {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr1GetTree() {
                
                #line 72 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr1Get() {
                
                #line 72 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr1Get() {
                this.GetValueTypeValues();
                return this.@__Expr1Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr3GetTree() {
                
                #line 82 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              selection.ToUpper();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr3Get() {
                
                #line 82 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              selection.ToUpper();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr3Get() {
                this.GetValueTypeValues();
                return this.@__Expr3Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 2)].Name != "selection") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext4 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool wasUserCreated;
            
            public Workflow1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string userName {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected string password {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr7GetTree() {
                
                #line 118 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              userName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr7Get() {
                
                #line 118 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              userName;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr7Get() {
                this.GetValueTypeValues();
                return this.@__Expr7Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr7Set(string value) {
                
                #line 118 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              userName = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr7Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr7Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr9GetTree() {
                
                #line 131 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              password;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr9Get() {
                
                #line 131 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              password;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr9Get() {
                this.GetValueTypeValues();
                return this.@__Expr9Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr9Set(string value) {
                
                #line 131 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              password = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr9Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr9Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr10GetTree() {
                
                #line 143 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              wasUserCreated;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr10Get() {
                
                #line 143 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              wasUserCreated;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr10Get() {
                this.GetValueTypeValues();
                return this.@__Expr10Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr10Set(bool value) {
                
                #line 143 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              wasUserCreated = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr10Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr10Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr14GetTree() {
                
                #line 169 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    currentState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr14Get() {
                
                #line 169 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
                    currentState;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr14Get() {
                this.GetValueTypeValues();
                return this.@__Expr14Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr14Set(string value) {
                
                #line 169 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
                    currentState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr14Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr14Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.wasUserCreated = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.wasUserCreated);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 2)].Name != "userName") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "password") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "wasUserCreated") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext4_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool wasUserCreated;
            
            public Workflow1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext4_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string userName {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected string password {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr6GetTree() {
                
                #line 123 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr6Get() {
                
                #line 123 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr6Get() {
                this.GetValueTypeValues();
                return this.@__Expr6Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr8GetTree() {
                
                #line 136 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr8Get() {
                
                #line 136 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr8Get() {
                this.GetValueTypeValues();
                return this.@__Expr8Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr11GetTree() {
                
                #line 148 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              password;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr11Get() {
                
                #line 148 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              password;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr11Get() {
                this.GetValueTypeValues();
                return this.@__Expr11Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr12GetTree() {
                
                #line 153 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              userName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr12Get() {
                
                #line 153 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              userName;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr12Get() {
                this.GetValueTypeValues();
                return this.@__Expr12Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr13GetTree() {
                
                #line 160 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              wasUserCreated;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr13Get() {
                
                #line 160 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              wasUserCreated;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr13Get() {
                this.GetValueTypeValues();
                return this.@__Expr13Get();
            }
            
            protected override void GetValueTypeValues() {
                this.wasUserCreated = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 2)].Name != "userName") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "password") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "wasUserCreated") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext5 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool wasSuccessfullLogin;
            
            public Workflow1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string userName {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected string password {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr16GetTree() {
                
                #line 194 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              userName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr16Get() {
                
                #line 194 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              userName;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr16Get() {
                this.GetValueTypeValues();
                return this.@__Expr16Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr16Set(string value) {
                
                #line 194 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              userName = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr16Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr16Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr18GetTree() {
                
                #line 207 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              password;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr18Get() {
                
                #line 207 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              password;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr18Get() {
                this.GetValueTypeValues();
                return this.@__Expr18Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr18Set(string value) {
                
                #line 207 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              password = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr18Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr18Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr19GetTree() {
                
                #line 224 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              wasSuccessfullLogin;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr19Get() {
                
                #line 224 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              wasSuccessfullLogin;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr19Get() {
                this.GetValueTypeValues();
                return this.@__Expr19Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr19Set(bool value) {
                
                #line 224 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              wasSuccessfullLogin = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr19Set(bool value) {
                this.GetValueTypeValues();
                this.@__Expr19Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr24GetTree() {
                
                #line 245 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    useId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr24Get() {
                
                #line 245 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
                    useId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr24Get() {
                this.GetValueTypeValues();
                return this.@__Expr24Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr24Set(string value) {
                
                #line 245 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
                    useId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr24Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr24Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr25GetTree() {
                
                #line 257 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    currentState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr25Get() {
                
                #line 257 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
                    currentState;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr25Get() {
                this.GetValueTypeValues();
                return this.@__Expr25Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr25Set(string value) {
                
                #line 257 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
                    currentState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr25Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr25Set(value);
                this.SetValueTypeValues();
            }
            
            protected override void GetValueTypeValues() {
                this.wasSuccessfullLogin = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            protected override void SetValueTypeValues() {
                this.SetVariableValue((4 + locationsOffset), this.wasSuccessfullLogin);
                base.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 2)].Name != "userName") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "password") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "wasSuccessfullLogin") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext5_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            protected bool wasSuccessfullLogin;
            
            public Workflow1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext5_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string userName {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected string password {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr15GetTree() {
                
                #line 199 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr15Get() {
                
                #line 199 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr15Get() {
                this.GetValueTypeValues();
                return this.@__Expr15Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr17GetTree() {
                
                #line 212 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr17Get() {
                
                #line 212 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr17Get() {
                this.GetValueTypeValues();
                return this.@__Expr17Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr20GetTree() {
                
                #line 229 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              userName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr20Get() {
                
                #line 229 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              userName;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr20Get() {
                this.GetValueTypeValues();
                return this.@__Expr20Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr21GetTree() {
                
                #line 219 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              password;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr21Get() {
                
                #line 219 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              password;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr21Get() {
                this.GetValueTypeValues();
                return this.@__Expr21Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr22GetTree() {
                
                #line 236 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              wasSuccessfullLogin;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr22Get() {
                
                #line 236 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              wasSuccessfullLogin;
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr22Get() {
                this.GetValueTypeValues();
                return this.@__Expr22Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr23GetTree() {
                
                #line 250 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    userName;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr23Get() {
                
                #line 250 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
                    userName;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr23Get() {
                this.GetValueTypeValues();
                return this.@__Expr23Get();
            }
            
            protected override void GetValueTypeValues() {
                this.wasSuccessfullLogin = ((bool)(this.GetVariableValue((4 + locationsOffset))));
                base.GetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 2)].Name != "userName") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "password") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "wasSuccessfullLogin") 
                            || (locationReferences[(offset + 4)].Type != typeof(bool)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext6 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext6(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext6(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string sendOrReveiveOption {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr27GetTree() {
                
                #line 279 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              sendOrReveiveOption;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr27Get() {
                
                #line 279 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              sendOrReveiveOption;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr27Get() {
                this.GetValueTypeValues();
                return this.@__Expr27Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr27Set(string value) {
                
                #line 279 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              sendOrReveiveOption = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr27Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr27Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr29GetTree() {
                
                #line 300 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                currentState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr29Get() {
                
                #line 300 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
                currentState;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr29Get() {
                this.GetValueTypeValues();
                return this.@__Expr29Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr29Set(string value) {
                
                #line 300 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
                currentState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr29Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr29Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr30GetTree() {
                
                #line 310 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                currentState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr30Get() {
                
                #line 310 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
                currentState;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr30Get() {
                this.GetValueTypeValues();
                return this.@__Expr30Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr30Set(string value) {
                
                #line 310 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
                currentState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr30Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr30Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr31GetTree() {
                
                #line 322 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                  currentState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr31Get() {
                
                #line 322 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
                  currentState;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr31Get() {
                this.GetValueTypeValues();
                return this.@__Expr31Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr31Set(string value) {
                
                #line 322 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
                  currentState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr31Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr31Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr32GetTree() {
                
                #line 333 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                currentState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr32Get() {
                
                #line 333 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
                currentState;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr32Get() {
                this.GetValueTypeValues();
                return this.@__Expr32Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr32Set(string value) {
                
                #line 333 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
                currentState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr32Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr32Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 2)].Name != "sendOrReveiveOption") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext6_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext6_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string sendOrReveiveOption {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr26GetTree() {
                
                #line 284 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr26Get() {
                
                #line 284 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr26Get() {
                this.GetValueTypeValues();
                return this.@__Expr26Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr28GetTree() {
                
                #line 294 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              sendOrReveiveOption.ToUpper();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr28Get() {
                
                #line 294 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              sendOrReveiveOption.ToUpper();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr28Get() {
                this.GetValueTypeValues();
                return this.@__Expr28Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 2)].Name != "sendOrReveiveOption") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext7 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext7(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext7(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string sendUserId {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            protected string message {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((3 + locationsOffset), value);
                }
            }
            
            protected string oldMessage {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((4 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr34GetTree() {
                
                #line 352 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              sendUserId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr34Get() {
                
                #line 352 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              sendUserId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr34Get() {
                this.GetValueTypeValues();
                return this.@__Expr34Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr34Set(string value) {
                
                #line 352 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              sendUserId = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr34Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr34Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr35GetTree() {
                
                #line 365 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              oldMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr35Get() {
                
                #line 365 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              oldMessage;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr35Get() {
                this.GetValueTypeValues();
                return this.@__Expr35Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr35Set(string value) {
                
                #line 365 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              oldMessage = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr35Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr35Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr38GetTree() {
                
                #line 377 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              message;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr38Get() {
                
                #line 377 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              message;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr38Get() {
                this.GetValueTypeValues();
                return this.@__Expr38Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr38Set(string value) {
                
                #line 377 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              message = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr38Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr38Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr41GetTree() {
                
                #line 402 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              currentState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr41Get() {
                
                #line 402 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              currentState;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr41Get() {
                this.GetValueTypeValues();
                return this.@__Expr41Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr41Set(string value) {
                
                #line 402 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              currentState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr41Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr41Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 2)].Name != "sendUserId") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "message") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "oldMessage") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext7_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext7_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string sendUserId {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            protected string message {
                get {
                    return ((string)(this.GetVariableValue((3 + locationsOffset))));
                }
            }
            
            protected string oldMessage {
                get {
                    return ((string)(this.GetVariableValue((4 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr33GetTree() {
                
                #line 357 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Console.ReadLine().Trim();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr33Get() {
                
                #line 357 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              Console.ReadLine().Trim();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr33Get() {
                this.GetValueTypeValues();
                return this.@__Expr33Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr36GetTree() {
                
                #line 370 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              sendUserId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr36Get() {
                
                #line 370 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              sendUserId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr36Get() {
                this.GetValueTypeValues();
                return this.@__Expr36Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr37GetTree() {
                
                #line 382 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              "From " + useId + ": " + Console.ReadLine()  +", " + oldMessage;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr37Get() {
                
                #line 382 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              "From " + useId + ": " + Console.ReadLine()  +", " + oldMessage;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr37Get() {
                this.GetValueTypeValues();
                return this.@__Expr37Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr39GetTree() {
                
                #line 394 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              message;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr39Get() {
                
                #line 394 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              message;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr39Get() {
                this.GetValueTypeValues();
                return this.@__Expr39Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr40GetTree() {
                
                #line 389 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              sendUserId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr40Get() {
                
                #line 389 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              sendUserId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr40Get() {
                this.GetValueTypeValues();
                return this.@__Expr40Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 5))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 5);
                }
                expectedLocationsCount = 5;
                if (((locationReferences[(offset + 2)].Name != "sendUserId") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 3)].Name != "message") 
                            || (locationReferences[(offset + 3)].Type != typeof(string)))) {
                    return false;
                }
                if (((locationReferences[(offset + 4)].Name != "oldMessage") 
                            || (locationReferences[(offset + 4)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext8 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext8(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext8(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string message {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr42GetTree() {
                
                #line 418 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              message;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr42Get() {
                
                #line 418 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              message;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr42Get() {
                this.GetValueTypeValues();
                return this.@__Expr42Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr42Set(string value) {
                
                #line 418 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              message = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr42Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr42Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr45GetTree() {
                
                #line 435 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              currentState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr45Get() {
                
                #line 435 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              currentState;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr45Get() {
                this.GetValueTypeValues();
                return this.@__Expr45Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr45Set(string value) {
                
                #line 435 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              currentState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr45Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr45Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 2)].Name != "message") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext8_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext8_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string message {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr43GetTree() {
                
                #line 423 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              useId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr43Get() {
                
                #line 423 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              useId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr43Get() {
                this.GetValueTypeValues();
                return this.@__Expr43Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr44GetTree() {
                
                #line 429 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
            "Messages: " + message;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr44Get() {
                
                #line 429 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
            "Messages: " + message;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr44Get() {
                this.GetValueTypeValues();
                return this.@__Expr44Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 2)].Name != "message") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext9 : Workflow1_TypedDataContext2 {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext9(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext9(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string clear {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
                set {
                    this.SetVariableValue((2 + locationsOffset), value);
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr47GetTree() {
                
                #line 451 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              clear;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr47Get() {
                
                #line 451 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              clear;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr47Get() {
                this.GetValueTypeValues();
                return this.@__Expr47Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr47Set(string value) {
                
                #line 451 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              clear = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr47Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr47Set(value);
                this.SetValueTypeValues();
            }
            
            internal System.Linq.Expressions.Expression @__Expr50GetTree() {
                
                #line 487 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              currentState;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr50Get() {
                
                #line 487 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              currentState;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr50Get() {
                this.GetValueTypeValues();
                return this.@__Expr50Get();
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public void @__Expr50Set(string value) {
                
                #line 487 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                
              currentState = value;
                
                #line default
                #line hidden
            }
            
            public void ValueType___Expr50Set(string value) {
                this.GetValueTypeValues();
                this.@__Expr50Set(value);
                this.SetValueTypeValues();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 2)].Name != "clear") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2.Validate(locationReferences, false, offset);
            }
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Activities", "4.0.0.0")]
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        private class Workflow1_TypedDataContext9_ForReadOnly : Workflow1_TypedDataContext2_ForReadOnly {
            
            private int locationsOffset;
            
            private static int expectedLocationsCount;
            
            public Workflow1_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locations, System.Activities.ActivityContext activityContext, bool computelocationsOffset) : 
                    base(locations, activityContext, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.Location> locations, bool computelocationsOffset) : 
                    base(locations, false) {
                if ((computelocationsOffset == true)) {
                    this.SetLocationsOffset((locations.Count - expectedLocationsCount));
                }
            }
            
            public Workflow1_TypedDataContext9_ForReadOnly(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences) : 
                    base(locationReferences) {
            }
            
            protected string clear {
                get {
                    return ((string)(this.GetVariableValue((2 + locationsOffset))));
                }
            }
            
            internal new static System.Activities.XamlIntegration.CompiledDataContext[] GetCompiledDataContextCacheHelper(object dataContextActivities, System.Activities.ActivityContext activityContext, System.Activities.Activity compiledRoot, bool forImplementation, int compiledDataContextCount) {
                return System.Activities.XamlIntegration.CompiledDataContext.GetCompiledDataContextCache(dataContextActivities, activityContext, compiledRoot, forImplementation, compiledDataContextCount);
            }
            
            public new virtual void SetLocationsOffset(int locationsOffsetValue) {
                locationsOffset = locationsOffsetValue;
                base.SetLocationsOffset(locationsOffset);
            }
            
            internal System.Linq.Expressions.Expression @__Expr46GetTree() {
                
                #line 456 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
              Console.ReadLine();
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr46Get() {
                
                #line 456 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              Console.ReadLine();
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr46Get() {
                this.GetValueTypeValues();
                return this.@__Expr46Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr48GetTree() {
                
                #line 463 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<bool>> expression = () => 
              clear.ToUpper().Trim().Equals("Y");
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public bool @__Expr48Get() {
                
                #line 463 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
              clear.ToUpper().Trim().Equals("Y");
                
                #line default
                #line hidden
            }
            
            public bool ValueType___Expr48Get() {
                this.GetValueTypeValues();
                return this.@__Expr48Get();
            }
            
            internal System.Linq.Expressions.Expression @__Expr49GetTree() {
                
                #line 472 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                System.Linq.Expressions.Expression<System.Func<string>> expression = () => 
                    useId;
                
                #line default
                #line hidden
                return base.RewriteExpressionTree(expression);
            }
            
            [System.Diagnostics.DebuggerHiddenAttribute()]
            public string @__Expr49Get() {
                
                #line 472 "S:\GITHUB\CSE 446\A3\LOGINWORKFLOWSERVICE\WORKFLOWMESSAGINGAPPLICATION\WORKFLOW1.XAML"
                return 
                    useId;
                
                #line default
                #line hidden
            }
            
            public string ValueType___Expr49Get() {
                this.GetValueTypeValues();
                return this.@__Expr49Get();
            }
            
            public new static bool Validate(System.Collections.Generic.IList<System.Activities.LocationReference> locationReferences, bool validateLocationCount, int offset) {
                if (((validateLocationCount == true) 
                            && (locationReferences.Count < 3))) {
                    return false;
                }
                if ((validateLocationCount == true)) {
                    offset = (locationReferences.Count - 3);
                }
                expectedLocationsCount = 3;
                if (((locationReferences[(offset + 2)].Name != "clear") 
                            || (locationReferences[(offset + 2)].Type != typeof(string)))) {
                    return false;
                }
                return Workflow1_TypedDataContext2_ForReadOnly.Validate(locationReferences, false, offset);
            }
        }
    }
}
