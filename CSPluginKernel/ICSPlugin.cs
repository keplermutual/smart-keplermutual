using System;

namespace CSPluginKernel
{

    //������Ĳ������ʵ������ӿ�
	public interface IPlugin 
    {
        bool Connect(IfuncObject app,IvarObject var);//����������ķ�����appΪ������ʵ��
		void OnDestory();
		void OnLoad();
		void Run();
	}


}