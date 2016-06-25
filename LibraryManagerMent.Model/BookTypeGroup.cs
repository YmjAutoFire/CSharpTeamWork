using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagerMent.Model
{
    public class BookTypeGroup
    {
        string typeID;

        public string TypeID
        {
            get { return typeID; }
            set { typeID = value; }
        }
        string typeName;

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        string parentID;

        public string ParentID
        {
            get { return parentID; }
            set { parentID = value; }
        }
    }
}
