using SPF.Client.APIs.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPF2019
{
    public class ClientDemo : ClientAPI
    {
        public string mstrfolderpath = string.Empty; 
        //调用基类的构造函数
        public ClientDemo(ref ClientAPICollection pobjclientapicollection):base(ref pobjclientapicollection,false,false)
        {

        }
        //代码逻辑
        protected override void ExecuteAPI()
        {
            mstrfolderpath=this.Method.SPFArgument1;
            GetAllfile();
            throw new NotImplementedException();
        }
        //遍历文件夹
        public void GetAllfile()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(mstrfolderpath);
            if(!directoryInfo.Exists)
            {
                throw new Exception(string.Format("{0}此文件夹不存在！",mstrfolderpath));
            }
            else
            {

            }
        }
    }
}
