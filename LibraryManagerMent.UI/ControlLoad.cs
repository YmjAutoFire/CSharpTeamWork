using LibraryManagerMent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagerMent.BLL
{
    /// <summary>
    /// 控件加载的各种可公有事件
    /// </summary>
    public class ControlLoad:Form
    {

        /// <summary>
        /// 递归加载左边图书类型的树
        /// </summary>
        public void LoadBookTypeTree(string parentID, TreeNode root, List<BookTypeGroup> list)
        {
            foreach (BookTypeGroup type in list)
            {
                if (type.ParentID == parentID)
                {
                    TreeNode child = new TreeNode(type.TypeName);
                    child.Tag = type;
                    LoadBookTypeTree(type.TypeID, child, list);
                    root.Nodes.Add(child);
                }
            }
        }

    }
}
