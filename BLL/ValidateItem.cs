using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class ValidateItem
    {
        private Label errorLog;
        private string value;
        private string condition;
        private string error;
        private Validate validate = new Validate();

        public ValidateItem(Label errorLog, string value, string condition, string error)
        {
            this.errorLog = errorLog;
            this.value = value;
            this.condition = condition;
            this.error = error;
        }

        public void showErrorLog(string error)
        {
            this.errorLog.Text = error;
        }

        public bool handleValidate()
        {
            if (this.errorLog != null && this.value != null && this.condition != null && this.error != null)
            {
                string[] conditionList = this.condition.Split('|');
                string[] errorList = this.error.Split('|');

                for (int i = 0; i < conditionList.Length; i++)
                {
                    errorList[i] = errorList[i].Trim();

                    if (conditionList[i].Contains(":"))
                    {
                        string[] conditionAndValue = conditionList[i].Split(':');

                        conditionAndValue[0] = conditionAndValue[0].Trim();
                        conditionAndValue[1] = conditionAndValue[1].Trim();

                        switch (conditionAndValue[0])
                        {
                            case "pattern":
                                {
                                    if (!Regex.IsMatch(this.value, conditionAndValue[1]))
                                    {
                                        this.showErrorLog(errorList[i]);

                                        return false;
                                    }

                                    break;
                                }
                            case "existed":
                                {
                                    if (this.validate.checkExisted(conditionAndValue[1], this.value))
                                    {
                                        this.showErrorLog(errorList[i]);

                                        return false;
                                    }

                                    break;
                                }
                            case "length":
                                {
                                    if (this.validate.checkLength(conditionAndValue[1], this.value))
                                    {
                                        this.showErrorLog(errorList[i]);

                                        return false;
                                    }

                                    break;
                                }
                        }
                    }
                    else
                    {
                        conditionList[i] = conditionList[i].Trim();

                        switch (conditionList[i])
                        {
                            case "empty":
                                {
                                    if (this.value == "")
                                    {
                                        this.showErrorLog(errorList[i]);

                                        return false;
                                    }

                                    break;
                                }
                        }
                    }
                }

                return true;
            }

            return false;
        }

        //public Label sErrorLog
        //{
        //    get
        //    {
        //        return this.errorLog;
        //    }
        //    set
        //    {
        //        this.errorLog = value;
        //    }
        //}

        //public string sValue
        //{
        //    get
        //    {
        //        return this.value;
        //    }
        //    set
        //    {
        //        this.value = value;
        //    }
        //}

        //public string sCondition
        //{
        //    get
        //    {
        //        return this.condition;
        //    }
        //    set
        //    {
        //        this.condition = value;
        //    }
        //}

        //public string sError
        //{
        //    get
        //    {
        //        return this.error;
        //    }
        //    set
        //    {
        //        this.error = value;
        //    }
        //}
    }
}
