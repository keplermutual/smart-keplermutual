using System;
using System.Drawing;

namespace CSPluginKernel {

    public interface IfuncObject
    {
		//void Alert( string msg );// ����һ����Ϣ
		//void ShowInStatusBar( string msg ); // ��ָ������Ϣ��ʾ��״̬��

		//void SetDelegate( Delegates whichOne , EventHandler target );
        void func_I_changtext(string text);

        void func_I_addtab(object control, string title);
	}

	/// <summary>
	/// �༭���������ʵ������ӿ�
	/// </summary>
    public interface IvarObject{

        //void func_I_changtext { get; set; }
		//Color SelectionColor { get; set; }
        //Font SelectionFont { get; set; }
        //int SelectionStart { get; set; }
        //int SelectionLength { get; set; }
        //string SelectionRTF { get; set; }

        //bool HasChanges { get; }

        //void Select( int start , int length );
        //void AppendText( string str );

        //void SaveFile( string fileName );
        //void SaveFile();

        //void OpenFile( string fileName );

        /// <summary>
        /// ѡ���·��
        /// </summary>
        string var_iwebpath { get; set; }

        /// <summary>
        /// �ļ�����
        /// </summary>
        string var_ifileencoding { get; set; }


	}

	public enum Delegates {
		Delegate_ActiveDocumentChanged ,
	}

}