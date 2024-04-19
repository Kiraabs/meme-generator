namespace MemeGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ���������� ������� ������ �����������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ButtonImageSelect_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog
            {
                Filter = "����� �����������|*.jpg;*.png;*.jpeg"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (!Template.Exists(ofd.FileName)) // ���� ����������� ��� � ����� ��������
                {
                    var mbr = MessageBox.Show
                    (
                        "�������� ��������� ����������� � ����� ��������?",
                        "�������������",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (mbr == DialogResult.Yes) Template.Create(ofd.FileName);
                }

                var tef = new TemplateEditorForm(ofd.FileName);
                tef.Show();
                Hide();
            }
        }

        /// <summary>
        /// ���������� ������� ������ �������.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void ButtonTemplateSelect_Click(object sender, EventArgs e)
        {
            var tsf = new TemplateSelectionForm();
            tsf.Show();
            Hide();
        }

        /// <summary>
        /// ���������� ������� �������� �����.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ��-�� ���� ������������ ����� �������, �������� �� ���������� ���������� �������.
            Application.Exit();
        }
    }
}
