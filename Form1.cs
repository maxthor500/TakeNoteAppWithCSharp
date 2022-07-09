namespace TakeNoteApp
{
    public partial class NoteApp : Form
    {
        System.Data.DataTable tableNote;
        public NoteApp()
        {
            InitializeComponent();
        }

        private void NoteApp_Load(object sender, EventArgs e)
        {
            tableNote = new System.Data.DataTable();
            tableNote.Columns.Add("Title", typeof(String));
            tableNote.Columns.Add("Message", typeof(String));

            dataGridView1.DataSource = tableNote;

            dataGridView1.Columns["Message"].Visible = false;
            dataGridView1.Columns["Title"].Width = 396;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            textTitle.Clear();
            textMessage.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            tableNote.Rows.Add(textTitle.Text, textMessage.Text);

            textTitle.Clear();
            textMessage.Clear();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            if (index >= 0)
            {
                textTitle.Text = tableNote.Rows[index].ItemArray[0].ToString();
                textMessage.Text = tableNote.Rows[index].ItemArray[1].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            tableNote.Rows[index].Delete();
        }
    }
}