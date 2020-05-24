using System.ComponentModel;
using System.Windows.Forms;

namespace ImGraph
{
    public partial class NodeView : UserControl
    {
        [Browsable(true)]
        public override string Text { get; set; }

        [Browsable(true)]
        public string ID { get; set; }

        [Browsable(true)]
        public string Caption { get; set; }

        public void Logic() { }

        public NodeView()
        {
            InitializeComponent();
        }
    }
}
