
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nic = new System.Windows.Forms.DataGridViewLinkColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ds = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gender";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 6);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Male";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(75, 6);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Moblie / Phone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(674, 73);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(589, 121);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Address";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 310);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 30);
            this.button1.TabIndex = 13;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 310);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 30);
            this.button2.TabIndex = 14;
            this.button2.Text = "delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "NIC no";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(316, 80);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.MaxLength = 12;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(206, 20);
            this.textBox6.TabIndex = 16;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(560, 310);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(641, 310);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(77, 30);
            this.button4.TabIndex = 18;
            this.button4.Text = "Report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(457, 24);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(131, 20);
            this.textBox8.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nic,
            this.name,
            this.dob,
            this.gender,
            this.phoneno,
            this.email,
            this.address,
            this.province,
            this.district,
            this.ds});
            this.dataGridView1.Location = new System.Drawing.Point(43, 372);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(873, 160);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nic
            // 
            this.nic.DataPropertyName = "nic";
            this.nic.HeaderText = "NIC";
            this.nic.Name = "nic";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // dob
            // 
            this.dob.DataPropertyName = "dob";
            this.dob.HeaderText = "DOB";
            this.dob.Name = "dob";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "Gender";
            this.gender.Name = "gender";
            // 
            // phoneno
            // 
            this.phoneno.DataPropertyName = "phoneno";
            this.phoneno.HeaderText = "Phone no";
            this.phoneno.Name = "phoneno";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "E-mail";
            this.email.Name = "email";
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // province
            // 
            this.province.DataPropertyName = "province";
            this.province.HeaderText = "Province";
            this.province.Name = "province";
            // 
            // district
            // 
            this.district.DataPropertyName = "district";
            this.district.HeaderText = "District";
            this.district.Name = "district";
            // 
            // ds
            // 
            this.ds.DataPropertyName = "ds";
            this.ds.HeaderText = "DS Division";
            this.ds.Name = "ds";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Western Province",
            "Central Province",
            "Southern Province",
            "Uva Province",
            "Sabaragamuwa Province",
            "NorthWest Province",
            "NorthCentral Province",
            "Nothern Province",
            "Eastern Province"});
            this.comboBox1.Location = new System.Drawing.Point(675, 165);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ampara",
            "Anuradhapura",
            "Badulla",
            "Batticaloa",
            "Colombo",
            "Galle",
            "Gampaha",
            "Hambantota",
            "Jaffna",
            "Kalutara",
            "Kandy",
            "Kegalle",
            "Kilinochchi",
            "Kurunegala",
            "Mannar",
            "Matale",
            "Matara",
            "Monaragala",
            "Mullaitivu",
            "NuwaraEliya",
            "Polonnaruwa",
            "Puttalam",
            "Ratnapura",
            "Trincomalee",
            "Vavuniya",
            ""});
            this.comboBox2.Location = new System.Drawing.Point(675, 204);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(113, 21);
            this.comboBox2.TabIndex = 25;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Akurana",
            "Delthota",
            "Doluwa",
            "Gagawata Korale",
            "Ganga Ihala Korale",
            "Harispattuwa",
            "Hatharaliyadda",
            "Kundasale",
            "Medadumbara",
            "Minipe",
            "Panvila",
            "Pasbage Korale",
            "Pathadumbara",
            "Pathahewaheta",
            "Poojapitiya",
            "Thumpane",
            "Udadumbara",
            "Udapalatha",
            "Udunuwara",
            "Yatinuwara",
            "Ambanganga Korale",
            "Dambulla",
            "Galewela",
            "Laggala-Pallegama",
            "Matale",
            "Naula",
            "Pallepola",
            "Rattota",
            "Ukuwela",
            "Wilgamuwa",
            "Yatawatta",
            "Ambagamuwa",
            "Hanguranketha",
            "Kothmale",
            "Nuwara Eliya",
            "Walapane",
            "Addalachchenai",
            "Akkaraipattu",
            "Alayadiwembu",
            "Ampara",
            "Damana",
            "Dehiattakandiya",
            "Eragama",
            "Kalmunai Muslim",
            "Kalmunai Tamil",
            "Karaitivu",
            "Lahugala",
            "Mahaoya",
            "Navithanveli",
            "Ninthavur",
            "Padiyathalawa",
            "Pothuvil",
            "Sainthamarathu",
            "Samanthurai",
            "Thirukkovil",
            "Uhana",
            "Eravur Pattu",
            "Eravur Town",
            "Kattankudy",
            "Koralai Pattu",
            "Koralai Pattu Central",
            "Koralai Pattu North",
            "Koralai Pattu South",
            "Koralai Pattu West",
            "Manmunai North",
            "Manmunai Pattu",
            "Manmunai S. and Eruvil Pattu",
            "Manmunai South West",
            "Manmunai West",
            "Porativu Pattu",
            "Gomarankadawala",
            "Kantalai",
            "Kinniya",
            "Kuchchaveli",
            "Morawewa",
            "Muttur",
            "Padavi Sri Pura",
            "Seruvila",
            "Thambalagamuwa",
            "Trincomalee",
            "Verugal",
            "Galnewa (30)",
            "Galenbindunuwewa (41)",
            "Horowpothana (38)",
            "Ipalogama (32)",
            "Kahatagasdigiliya (40)",
            "Kebithigollewa (26)",
            "Kekirawa (53)",
            "Mahavilachchiya (17)",
            "Medawachchiya (37)",
            "Mihinthale (25)",
            "Nachchadoowa (19)",
            "Nochchiyagama (36)",
            "Nuwaragam Palatha Central (40)",
            "Nuwaragam Palatha East (29)",
            "Padaviya (15)",
            "Palagala (35)",
            "Palugaswewa (16)",
            "Rajanganaya (21)",
            "Rambewa (38)",
            "Thalawa (39)",
            "Thambuttegama (26)",
            "Thirappane (41)",
            "Dimbulagala",
            "Elahera",
            "Hingurakgoda",
            "Lankapura",
            "Medirigiriya",
            "Thamankaduwa",
            "Welikanda",
            "Delft",
            "Island North",
            "Island South",
            "Jaffna",
            "Karainagar",
            "Nallur",
            "Thenmaradchi",
            "Vadamaradchi East",
            "Vadamaradchi North",
            "Vadamaradchi South-West",
            "Valikamam East",
            "Valikamam North",
            "Valikamam South",
            "Valikamam South-West",
            "Valikamam West",
            "Kandavalai",
            "Karachchi",
            "Pachchilaipalli",
            "Poonakary",
            "Madhu",
            "Mannar",
            "Manthai West",
            "Musalai",
            "Nanaddan",
            "Manthai East",
            "Maritimepattu",
            "Oddusuddan",
            "Puthukudiyiruppu",
            "Thunukkai",
            "Welioya",
            "Vavuniya",
            "Vavuniya North",
            "Vavuniya South",
            "Vengalacheddikulam",
            "Alawwa",
            "Ambanpola",
            "Bamunakotuwa",
            "Bingiriya",
            "Ehetuwewa",
            "Galgamuwa",
            "Ganewatta",
            "Giribawa",
            "Ibbagamuwa",
            "Katupotha",
            "Kobeigane",
            "Kotavehera",
            "Kuliyapitiya East",
            "Kuliyapitiya West",
            "Kurunegala",
            "Mahawa",
            "Mallawapitiya",
            "Maspotha",
            "Mawathagama",
            "Narammala",
            "Nikaweratiya",
            "Panduwasnuwara",
            "Pannala",
            "Polgahawela",
            "Polpithigama",
            "Rasnayakapura",
            "Rideegama",
            "Udubaddawa",
            "Wariyapola",
            "Weerambugedara",
            "Anamaduwa",
            "Arachchikattuwa",
            "Chilaw",
            "Dankotuwa",
            "Kalpitiya",
            "Karuwalagaswewa",
            "Madampe",
            "Mahakumbukkadawala",
            "Mahawewa",
            "Mundalama",
            "Nattandiya",
            "Nawagattegama",
            "Pallama",
            "Puttalam",
            "Vanathavilluwa",
            "Wennappuwa",
            "Aranayaka",
            "Bulathkohupitiya",
            "Dehiovita",
            "Deraniyagala",
            "Galigamuwa",
            "Kegalle",
            "Mawanella",
            "Rambukkana",
            "Ruwanwella",
            "Warakapola",
            "Yatiyanthota",
            "Ayagama",
            "Balangoda",
            "Eheliyagoda",
            "Elapattha",
            "Embilipitiya",
            "Godakawela",
            "Imbulpe",
            "Kahawatta",
            "Kalawana",
            "Kiriella",
            "Kolonna",
            "Kuruvita",
            "Nivithigala",
            "Opanayaka",
            "Pelmadulla",
            "Ratnapura",
            "Weligepola",
            "Akmeemana",
            "Ambalangoda",
            "Baddegama",
            "Balapitiya",
            "Benthota",
            "Bope-Poddala",
            "Elpitiya",
            "Galle",
            "Gonapinuwala",
            "Habaraduwa",
            "Hikkaduwa",
            "Imaduwa",
            "Karandeniya",
            "Nagoda",
            "Neluwa",
            "Niyagama",
            "Thawalama",
            "Welivitiya-Divithura",
            "Yakkalamulla",
            "Ambalantota",
            "Angunakolapelessa",
            "Beliatta",
            "Hambantota",
            "Katuwana",
            "Lunugamvehera",
            "Okewela",
            "Sooriyawewa",
            "Tangalle",
            "Thissamaharama",
            "Walasmulla",
            "Weeraketiya",
            "Akuressa",
            "Athuraliya",
            "Devinuwara",
            "Dickwella",
            "Hakmana",
            "Kamburupitiya",
            "Kirinda Puhulwella",
            "Kotapola",
            "Malimbada",
            "Matara",
            "Mulatiyana",
            "Pasgoda",
            "Pitabeddara",
            "Thihagoda",
            "Weligama",
            "Welipitiya",
            "Badulla",
            "Bandarawela",
            "Ella",
            "Haldummulla",
            "Hali-Ela",
            "Haputale",
            "Kandaketiya",
            "Lunugala",
            "Mahiyanganaya",
            "Meegahakivula",
            "Passara",
            "Rideemaliyadda",
            "Soranathota",
            "Uva-Paranagama",
            "Welimada",
            "Badalkumbura",
            "Bibile",
            "Buttala",
            "Katharagama",
            "Madulla",
            "Medagama",
            "Moneragala",
            "Sevanagala",
            "Siyambalanduwa",
            "Thanamalvila",
            "Wellawaya",
            "Colombo (35)",
            "Dehiwala (15)",
            "Homagama (81)",
            "Kaduwela (57)",
            "Kesbewa (73)",
            "Kolonnawa (46)",
            "Kotte (20)",
            "Maharagama (41)",
            "Moratuwa (42)",
            "Padukka (46)",
            "Ratmalana (13)",
            "Seethawaka (68)",
            "Thimbirigasyaya (29)",
            "Attanagalla",
            "Biyagama",
            "Divulapitiya",
            "Dompe",
            "Gampaha",
            "Ja-Ela",
            "Katana",
            "Kelaniya",
            "Mahara",
            "Minuwangoda",
            "Mirigama",
            "Negombo",
            "Wattala",
            "Agalawatta",
            "Bandaragama",
            "Beruwala",
            "Bulathsinhala",
            "Dodangoda",
            "Horana",
            "Ingiriya",
            "Kalutara",
            "Madurawela",
            "Mathugama",
            "Millaniya",
            "Palindanuwara",
            "Panadura",
            "Walallavita"});
            this.comboBox3.Location = new System.Drawing.Point(674, 243);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(114, 21);
            this.comboBox3.TabIndex = 26;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 165);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Province";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(589, 206);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "District";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(589, 241);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "DS Division";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(316, 240);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(2);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(206, 20);
            this.maskedTextBox1.TabIndex = 30;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maskedTextBox1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(316, 194);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(152, 28);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.AllowDrop = true;
            this.button6.Location = new System.Drawing.Point(619, 19);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(67, 30);
            this.button6.TabIndex = 35;
            this.button6.Text = "OK";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(316, 118);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.MaxLength = 12;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 36;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(675, 116);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(205, 35);
            this.richTextBox1.TabIndex = 37;
            this.richTextBox1.Text = "";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(316, 153);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(150, 25);
            this.bunifuDatepicker1.TabIndex = 151;
            this.bunifuDatepicker1.Value = new System.DateTime(2021, 7, 5, 22, 21, 52, 239);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(927, 531);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Peoples Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private System.Windows.Forms.DataGridViewLinkColumn nic;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dob;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneno;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn ds;
    }
}

