﻿namespace Movie_omdb
{
    partial class Omdb_main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Omdb_main));
            this.ricerca = new System.Windows.Forms.TextBox();
            this.generic = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.searchtitle = new System.Windows.Forms.Label();
            this.searchyear = new System.Windows.Forms.Label();
            this.desc_m_3 = new System.Windows.Forms.Label();
            this.searchtype = new System.Windows.Forms.Label();
            this.desc_m_2 = new System.Windows.Forms.Label();
            this.desc_m_1 = new System.Windows.Forms.Label();
            this.main = new System.Windows.Forms.Panel();
            this.rated = new System.Windows.Forms.Label();
            this.year = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.desc_2 = new System.Windows.Forms.Label();
            this.desc_1 = new System.Windows.Forms.Label();
            this.desc_3 = new System.Windows.Forms.Label();
            this.detail = new System.Windows.Forms.Panel();
            this.production = new System.Windows.Forms.Label();
            this.dvd = new System.Windows.Forms.Label();
            this.metascore = new System.Windows.Forms.Label();
            this.awards = new System.Windows.Forms.Label();
            this.desc_16 = new System.Windows.Forms.Label();
            this.desc_15 = new System.Windows.Forms.Label();
            this.desc_14 = new System.Windows.Forms.Label();
            this.desc_13 = new System.Windows.Forms.Label();
            this.boxoffice = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.Label();
            this.desc_12 = new System.Windows.Forms.Label();
            this.desc_10 = new System.Windows.Forms.Label();
            this.desc_11 = new System.Windows.Forms.Label();
            this.desc_9 = new System.Windows.Forms.Label();
            this.writer = new System.Windows.Forms.Label();
            this.director = new System.Windows.Forms.Label();
            this.desc_8 = new System.Windows.Forms.Label();
            this.desc_7 = new System.Windows.Forms.Label();
            this.desc_6 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.desc_5 = new System.Windows.Forms.Label();
            this.runtime = new System.Windows.Forms.Label();
            this.desc_4 = new System.Windows.Forms.Label();
            this.released = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_1 = new System.Windows.Forms.Button();
            this.b_5 = new System.Windows.Forms.Button();
            this.b_2 = new System.Windows.Forms.Button();
            this.b_4 = new System.Windows.Forms.Button();
            this.b_3 = new System.Windows.Forms.Button();
            this.searchlist = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.poster = new System.Windows.Forms.PictureBox();
            this.search = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.actors = new System.Windows.Forms.Label();
            this.desc_17 = new System.Windows.Forms.Label();
            this.plot = new System.Windows.Forms.Label();
            this.desc_18 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.main.SuspendLayout();
            this.detail.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ricerca
            // 
            this.ricerca.AcceptsReturn = true;
            this.ricerca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ricerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ricerca.Location = new System.Drawing.Point(6, 3);
            this.ricerca.Name = "ricerca";
            this.ricerca.Size = new System.Drawing.Size(171, 22);
            this.ricerca.TabIndex = 1;
            this.ricerca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ricerca_KeyPress);
            // 
            // generic
            // 
            this.generic.AutoSize = true;
            this.generic.BackColor = System.Drawing.Color.Black;
            this.generic.Cursor = System.Windows.Forms.Cursors.Default;
            this.generic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generic.ForeColor = System.Drawing.Color.White;
            this.generic.Location = new System.Drawing.Point(367, 12);
            this.generic.Name = "generic";
            this.generic.Size = new System.Drawing.Size(110, 24);
            this.generic.TabIndex = 19;
            this.generic.Tag = "";
            this.generic.Text = "Panoramica&";
            this.generic.Click += new System.EventHandler(this.generic_click);
            this.generic.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.generic.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // details
            // 
            this.details.AutoSize = true;
            this.details.BackColor = System.Drawing.Color.Black;
            this.details.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details.ForeColor = System.Drawing.Color.White;
            this.details.Location = new System.Drawing.Point(483, 12);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(71, 24);
            this.details.TabIndex = 20;
            this.details.Tag = "";
            this.details.Text = "Dettagli";
            this.details.Click += new System.EventHandler(this.details_Click);
            this.details.MouseEnter += new System.EventHandler(this.label_MouseEnter);
            this.details.MouseLeave += new System.EventHandler(this.label_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ricerca);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Location = new System.Drawing.Point(12, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(177, 30);
            this.panel3.TabIndex = 23;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Movie_omdb.Properties.Resources.search_left;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(7, 30);
            this.pictureBox5.TabIndex = 24;
            this.pictureBox5.TabStop = false;
            // 
            // searchtitle
            // 
            this.searchtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchtitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtitle.Location = new System.Drawing.Point(61, 5);
            this.searchtitle.Name = "searchtitle";
            this.searchtitle.Size = new System.Drawing.Size(225, 54);
            this.searchtitle.TabIndex = 13;
            this.searchtitle.Text = "-";
            this.searchtitle.UseCompatibleTextRendering = true;
            // 
            // searchyear
            // 
            this.searchyear.AutoSize = true;
            this.searchyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchyear.Location = new System.Drawing.Point(61, 59);
            this.searchyear.Name = "searchyear";
            this.searchyear.Size = new System.Drawing.Size(11, 22);
            this.searchyear.TabIndex = 14;
            this.searchyear.Text = "-";
            this.searchyear.UseCompatibleTextRendering = true;
            // 
            // desc_m_3
            // 
            this.desc_m_3.AutoSize = true;
            this.desc_m_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_m_3.Location = new System.Drawing.Point(3, 81);
            this.desc_m_3.Name = "desc_m_3";
            this.desc_m_3.Size = new System.Drawing.Size(44, 22);
            this.desc_m_3.TabIndex = 12;
            this.desc_m_3.Text = "Tipo: ";
            this.desc_m_3.UseCompatibleTextRendering = true;
            // 
            // searchtype
            // 
            this.searchtype.AutoSize = true;
            this.searchtype.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtype.Location = new System.Drawing.Point(61, 80);
            this.searchtype.Name = "searchtype";
            this.searchtype.Size = new System.Drawing.Size(11, 22);
            this.searchtype.TabIndex = 15;
            this.searchtype.Text = "-";
            this.searchtype.UseCompatibleTextRendering = true;
            // 
            // desc_m_2
            // 
            this.desc_m_2.AutoSize = true;
            this.desc_m_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_m_2.Location = new System.Drawing.Point(3, 59);
            this.desc_m_2.Name = "desc_m_2";
            this.desc_m_2.Size = new System.Drawing.Size(50, 22);
            this.desc_m_2.TabIndex = 10;
            this.desc_m_2.Text = "Anno: ";
            this.desc_m_2.UseCompatibleTextRendering = true;
            // 
            // desc_m_1
            // 
            this.desc_m_1.AutoSize = true;
            this.desc_m_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_m_1.Location = new System.Drawing.Point(3, 5);
            this.desc_m_1.Name = "desc_m_1";
            this.desc_m_1.Size = new System.Drawing.Size(52, 22);
            this.desc_m_1.TabIndex = 11;
            this.desc_m_1.Text = "Titolo: ";
            this.desc_m_1.UseCompatibleTextRendering = true;
            // 
            // main
            // 
            this.main.Controls.Add(this.desc_m_1);
            this.main.Controls.Add(this.desc_m_2);
            this.main.Controls.Add(this.searchtype);
            this.main.Controls.Add(this.desc_m_3);
            this.main.Controls.Add(this.searchyear);
            this.main.Controls.Add(this.searchtitle);
            this.main.Location = new System.Drawing.Point(592, 66);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(298, 294);
            this.main.TabIndex = 17;
            // 
            // rated
            // 
            this.rated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rated.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rated.Location = new System.Drawing.Point(122, 80);
            this.rated.Name = "rated";
            this.rated.Size = new System.Drawing.Size(173, 18);
            this.rated.TabIndex = 7;
            this.rated.Text = "-";
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year.Location = new System.Drawing.Point(59, 59);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(13, 18);
            this.year.TabIndex = 5;
            this.year.Text = "-";
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(59, 5);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(236, 54);
            this.title.TabIndex = 3;
            this.title.Text = "-";
            // 
            // desc_2
            // 
            this.desc_2.AutoSize = true;
            this.desc_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_2.Location = new System.Drawing.Point(3, 59);
            this.desc_2.Name = "desc_2";
            this.desc_2.Size = new System.Drawing.Size(50, 22);
            this.desc_2.TabIndex = 26;
            this.desc_2.Text = "Anno: ";
            this.desc_2.UseCompatibleTextRendering = true;
            // 
            // desc_1
            // 
            this.desc_1.AutoSize = true;
            this.desc_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_1.Location = new System.Drawing.Point(3, 5);
            this.desc_1.Name = "desc_1";
            this.desc_1.Size = new System.Drawing.Size(52, 22);
            this.desc_1.TabIndex = 27;
            this.desc_1.Text = "Titolo: ";
            this.desc_1.UseCompatibleTextRendering = true;
            // 
            // desc_3
            // 
            this.desc_3.AutoSize = true;
            this.desc_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_3.Location = new System.Drawing.Point(3, 81);
            this.desc_3.Name = "desc_3";
            this.desc_3.Size = new System.Drawing.Size(117, 22);
            this.desc_3.TabIndex = 28;
            this.desc_3.Text = "Classificazione: ";
            this.desc_3.UseCompatibleTextRendering = true;
            // 
            // detail
            // 
            this.detail.Controls.Add(this.plot);
            this.detail.Controls.Add(this.desc_18);
            this.detail.Controls.Add(this.actors);
            this.detail.Controls.Add(this.desc_17);
            this.detail.Controls.Add(this.production);
            this.detail.Controls.Add(this.dvd);
            this.detail.Controls.Add(this.metascore);
            this.detail.Controls.Add(this.awards);
            this.detail.Controls.Add(this.desc_16);
            this.detail.Controls.Add(this.desc_15);
            this.detail.Controls.Add(this.desc_14);
            this.detail.Controls.Add(this.desc_13);
            this.detail.Controls.Add(this.boxoffice);
            this.detail.Controls.Add(this.type);
            this.detail.Controls.Add(this.country);
            this.detail.Controls.Add(this.language);
            this.detail.Controls.Add(this.desc_12);
            this.detail.Controls.Add(this.desc_10);
            this.detail.Controls.Add(this.desc_11);
            this.detail.Controls.Add(this.desc_9);
            this.detail.Controls.Add(this.writer);
            this.detail.Controls.Add(this.director);
            this.detail.Controls.Add(this.desc_8);
            this.detail.Controls.Add(this.desc_7);
            this.detail.Controls.Add(this.desc_6);
            this.detail.Controls.Add(this.genre);
            this.detail.Controls.Add(this.desc_5);
            this.detail.Controls.Add(this.runtime);
            this.detail.Controls.Add(this.desc_4);
            this.detail.Controls.Add(this.released);
            this.detail.Controls.Add(this.desc_3);
            this.detail.Controls.Add(this.desc_1);
            this.detail.Controls.Add(this.desc_2);
            this.detail.Controls.Add(this.title);
            this.detail.Controls.Add(this.year);
            this.detail.Controls.Add(this.rated);
            this.detail.Location = new System.Drawing.Point(592, 66);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(298, 588);
            this.detail.TabIndex = 25;
            this.detail.Visible = false;
            // 
            // production
            // 
            this.production.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.production.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.production.Location = new System.Drawing.Point(98, 389);
            this.production.Name = "production";
            this.production.Size = new System.Drawing.Size(188, 18);
            this.production.TabIndex = 65;
            this.production.Text = "-";
            // 
            // dvd
            // 
            this.dvd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvd.Location = new System.Drawing.Point(78, 367);
            this.dvd.Name = "dvd";
            this.dvd.Size = new System.Drawing.Size(208, 18);
            this.dvd.TabIndex = 64;
            this.dvd.Text = "-";
            // 
            // metascore
            // 
            this.metascore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metascore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metascore.Location = new System.Drawing.Point(95, 345);
            this.metascore.Name = "metascore";
            this.metascore.Size = new System.Drawing.Size(191, 18);
            this.metascore.TabIndex = 63;
            this.metascore.Text = "-";
            // 
            // awards
            // 
            this.awards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.awards.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awards.Location = new System.Drawing.Point(78, 323);
            this.awards.Name = "awards";
            this.awards.Size = new System.Drawing.Size(208, 18);
            this.awards.TabIndex = 62;
            this.awards.Text = "-";
            // 
            // desc_16
            // 
            this.desc_16.AutoSize = true;
            this.desc_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_16.Location = new System.Drawing.Point(3, 389);
            this.desc_16.Name = "desc_16";
            this.desc_16.Size = new System.Drawing.Size(92, 22);
            this.desc_16.TabIndex = 61;
            this.desc_16.Text = "Produzione: ";
            this.desc_16.UseCompatibleTextRendering = true;
            // 
            // desc_15
            // 
            this.desc_15.AutoSize = true;
            this.desc_15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_15.Location = new System.Drawing.Point(3, 367);
            this.desc_15.Name = "desc_15";
            this.desc_15.Size = new System.Drawing.Size(47, 22);
            this.desc_15.TabIndex = 60;
            this.desc_15.Text = "DVD: ";
            this.desc_15.UseCompatibleTextRendering = true;
            // 
            // desc_14
            // 
            this.desc_14.AutoSize = true;
            this.desc_14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_14.Location = new System.Drawing.Point(3, 345);
            this.desc_14.Name = "desc_14";
            this.desc_14.Size = new System.Drawing.Size(86, 22);
            this.desc_14.TabIndex = 59;
            this.desc_14.Text = "Metascore: ";
            this.desc_14.UseCompatibleTextRendering = true;
            // 
            // desc_13
            // 
            this.desc_13.AutoSize = true;
            this.desc_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_13.Location = new System.Drawing.Point(3, 323);
            this.desc_13.Name = "desc_13";
            this.desc_13.Size = new System.Drawing.Size(54, 22);
            this.desc_13.TabIndex = 58;
            this.desc_13.Text = "Premi: ";
            this.desc_13.UseCompatibleTextRendering = true;
            // 
            // boxoffice
            // 
            this.boxoffice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.boxoffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxoffice.Location = new System.Drawing.Point(78, 301);
            this.boxoffice.Name = "boxoffice";
            this.boxoffice.Size = new System.Drawing.Size(208, 18);
            this.boxoffice.TabIndex = 55;
            this.boxoffice.Text = "-";
            // 
            // type
            // 
            this.type.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.type.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(78, 279);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(208, 18);
            this.type.TabIndex = 54;
            this.type.Text = "-";
            // 
            // country
            // 
            this.country.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.country.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.country.Location = new System.Drawing.Point(125, 257);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(161, 18);
            this.country.TabIndex = 53;
            this.country.Text = "-";
            // 
            // language
            // 
            this.language.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.language.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language.Location = new System.Drawing.Point(125, 235);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(161, 18);
            this.language.TabIndex = 52;
            this.language.Text = "-";
            // 
            // desc_12
            // 
            this.desc_12.AutoSize = true;
            this.desc_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_12.Location = new System.Drawing.Point(3, 301);
            this.desc_12.Name = "desc_12";
            this.desc_12.Size = new System.Drawing.Size(67, 22);
            this.desc_12.TabIndex = 51;
            this.desc_12.Text = "Incasso: ";
            this.desc_12.UseCompatibleTextRendering = true;
            // 
            // desc_10
            // 
            this.desc_10.AutoSize = true;
            this.desc_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_10.Location = new System.Drawing.Point(3, 257);
            this.desc_10.Name = "desc_10";
            this.desc_10.Size = new System.Drawing.Size(120, 22);
            this.desc_10.TabIndex = 51;
            this.desc_10.Text = "Paese d\'origine: ";
            this.desc_10.UseCompatibleTextRendering = true;
            // 
            // desc_11
            // 
            this.desc_11.AutoSize = true;
            this.desc_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_11.Location = new System.Drawing.Point(3, 279);
            this.desc_11.Name = "desc_11";
            this.desc_11.Size = new System.Drawing.Size(44, 22);
            this.desc_11.TabIndex = 50;
            this.desc_11.Text = "Tipo: ";
            this.desc_11.UseCompatibleTextRendering = true;
            // 
            // desc_9
            // 
            this.desc_9.AutoSize = true;
            this.desc_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_9.Location = new System.Drawing.Point(3, 235);
            this.desc_9.Name = "desc_9";
            this.desc_9.Size = new System.Drawing.Size(123, 22);
            this.desc_9.TabIndex = 50;
            this.desc_9.Text = "Lingua originale: ";
            this.desc_9.UseCompatibleTextRendering = true;
            // 
            // writer
            // 
            this.writer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.writer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writer.Location = new System.Drawing.Point(78, 191);
            this.writer.Name = "writer";
            this.writer.Size = new System.Drawing.Size(208, 44);
            this.writer.TabIndex = 46;
            this.writer.Text = "-";
            // 
            // director
            // 
            this.director.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.director.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.director.Location = new System.Drawing.Point(78, 169);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(217, 18);
            this.director.TabIndex = 45;
            this.director.Text = "-";
            // 
            // desc_8
            // 
            this.desc_8.AutoSize = true;
            this.desc_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_8.Location = new System.Drawing.Point(3, 191);
            this.desc_8.Name = "desc_8";
            this.desc_8.Size = new System.Drawing.Size(71, 22);
            this.desc_8.TabIndex = 44;
            this.desc_8.Text = "Scrittore: ";
            this.desc_8.UseCompatibleTextRendering = true;
            // 
            // desc_7
            // 
            this.desc_7.AutoSize = true;
            this.desc_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_7.Location = new System.Drawing.Point(3, 169);
            this.desc_7.Name = "desc_7";
            this.desc_7.Size = new System.Drawing.Size(66, 22);
            this.desc_7.TabIndex = 43;
            this.desc_7.Text = "Regista: ";
            this.desc_7.UseCompatibleTextRendering = true;
            // 
            // desc_6
            // 
            this.desc_6.AutoSize = true;
            this.desc_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_6.Location = new System.Drawing.Point(3, 147);
            this.desc_6.Name = "desc_6";
            this.desc_6.Size = new System.Drawing.Size(65, 22);
            this.desc_6.TabIndex = 40;
            this.desc_6.Text = "Genere: ";
            this.desc_6.UseCompatibleTextRendering = true;
            // 
            // genre
            // 
            this.genre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.Location = new System.Drawing.Point(78, 147);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(217, 18);
            this.genre.TabIndex = 39;
            this.genre.Text = "-";
            // 
            // desc_5
            // 
            this.desc_5.AutoSize = true;
            this.desc_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_5.Location = new System.Drawing.Point(3, 125);
            this.desc_5.Name = "desc_5";
            this.desc_5.Size = new System.Drawing.Size(60, 22);
            this.desc_5.TabIndex = 36;
            this.desc_5.Text = "Durata: ";
            this.desc_5.UseCompatibleTextRendering = true;
            // 
            // runtime
            // 
            this.runtime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runtime.Location = new System.Drawing.Point(78, 125);
            this.runtime.Name = "runtime";
            this.runtime.Size = new System.Drawing.Size(217, 18);
            this.runtime.TabIndex = 35;
            this.runtime.Text = "-";
            // 
            // desc_4
            // 
            this.desc_4.AutoSize = true;
            this.desc_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_4.Location = new System.Drawing.Point(3, 103);
            this.desc_4.Name = "desc_4";
            this.desc_4.Size = new System.Drawing.Size(68, 22);
            this.desc_4.TabIndex = 30;
            this.desc_4.Text = "Rilascio: ";
            this.desc_4.UseCompatibleTextRendering = true;
            // 
            // released
            // 
            this.released.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.released.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.released.Location = new System.Drawing.Point(78, 103);
            this.released.Name = "released";
            this.released.Size = new System.Drawing.Size(217, 18);
            this.released.TabIndex = 29;
            this.released.Text = "-";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.b_1);
            this.panel2.Controls.Add(this.b_5);
            this.panel2.Controls.Add(this.b_2);
            this.panel2.Controls.Add(this.b_4);
            this.panel2.Controls.Add(this.b_3);
            this.panel2.Location = new System.Drawing.Point(85, 591);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 36);
            this.panel2.TabIndex = 31;
            // 
            // b_1
            // 
            this.b_1.BackColor = System.Drawing.Color.Black;
            this.b_1.FlatAppearance.BorderSize = 0;
            this.b_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_1.Location = new System.Drawing.Point(0, 0);
            this.b_1.Name = "b_1";
            this.b_1.Size = new System.Drawing.Size(36, 36);
            this.b_1.TabIndex = 26;
            this.b_1.Text = "b_1";
            this.b_1.UseVisualStyleBackColor = false;
            this.b_1.Click += new System.EventHandler(this.nav_click);
            this.b_1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_mouseDown);
            this.b_1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_mouseUp);
            // 
            // b_5
            // 
            this.b_5.BackColor = System.Drawing.Color.Black;
            this.b_5.FlatAppearance.BorderSize = 0;
            this.b_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_5.Location = new System.Drawing.Point(168, 0);
            this.b_5.Name = "b_5";
            this.b_5.Size = new System.Drawing.Size(36, 36);
            this.b_5.TabIndex = 30;
            this.b_5.Text = "b_5";
            this.b_5.UseVisualStyleBackColor = false;
            this.b_5.Click += new System.EventHandler(this.nav_click);
            this.b_5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_mouseDown);
            this.b_5.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_mouseUp);
            // 
            // b_2
            // 
            this.b_2.BackColor = System.Drawing.Color.Black;
            this.b_2.FlatAppearance.BorderSize = 0;
            this.b_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_2.Location = new System.Drawing.Point(42, 0);
            this.b_2.Name = "b_2";
            this.b_2.Size = new System.Drawing.Size(36, 36);
            this.b_2.TabIndex = 27;
            this.b_2.Text = "b_2";
            this.b_2.UseVisualStyleBackColor = false;
            this.b_2.Click += new System.EventHandler(this.nav_click);
            this.b_2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_mouseDown);
            this.b_2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_mouseUp);
            // 
            // b_4
            // 
            this.b_4.BackColor = System.Drawing.Color.Black;
            this.b_4.FlatAppearance.BorderSize = 0;
            this.b_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_4.Location = new System.Drawing.Point(126, 0);
            this.b_4.Name = "b_4";
            this.b_4.Size = new System.Drawing.Size(36, 36);
            this.b_4.TabIndex = 29;
            this.b_4.Text = "b_4";
            this.b_4.UseVisualStyleBackColor = false;
            this.b_4.Click += new System.EventHandler(this.nav_click);
            this.b_4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_mouseDown);
            this.b_4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_mouseUp);
            // 
            // b_3
            // 
            this.b_3.BackColor = System.Drawing.Color.Black;
            this.b_3.FlatAppearance.BorderSize = 0;
            this.b_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_3.Location = new System.Drawing.Point(84, 0);
            this.b_3.Name = "b_3";
            this.b_3.Size = new System.Drawing.Size(36, 36);
            this.b_3.TabIndex = 28;
            this.b_3.Text = "b_3";
            this.b_3.UseVisualStyleBackColor = false;
            this.b_3.Click += new System.EventHandler(this.nav_click);
            // 
            // searchlist
            // 
            this.searchlist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.searchlist.BackColor = System.Drawing.Color.Silver;
            this.searchlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchlist.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.searchlist.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchlist.FormattingEnabled = true;
            this.searchlist.ItemHeight = 24;
            this.searchlist.Location = new System.Drawing.Point(0, 33);
            this.searchlist.Name = "searchlist";
            this.searchlist.Size = new System.Drawing.Size(349, 432);
            this.searchlist.TabIndex = 9;
            this.searchlist.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.searchlist_DrawItem);
            this.searchlist.SelectedIndexChanged += new System.EventHandler(this.searchlist_SelectedIndexChanged);
            this.searchlist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchlist_KeyDown);
            this.searchlist.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchlist_KeyUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.searchlist);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 516);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackgroundImage = global::Movie_omdb.Properties.Resources.list_bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 482);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(349, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Movie_omdb.Properties.Resources.list_top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // poster
            // 
            this.poster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.poster.ErrorImage = global::Movie_omdb.Properties.Resources.no_img;
            this.poster.Location = new System.Drawing.Point(367, 67);
            this.poster.MaximumSize = new System.Drawing.Size(300, 380);
            this.poster.MinimumSize = new System.Drawing.Size(165, 209);
            this.poster.Name = "poster";
            this.poster.Size = new System.Drawing.Size(220, 380);
            this.poster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.poster.TabIndex = 8;
            this.poster.TabStop = false;
            this.poster.Resize += new System.EventHandler(this.poster_Resize);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.DarkOrange;
            this.search.BackgroundImage = global::Movie_omdb.Properties.Resources.search_right;
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Image = global::Movie_omdb.Properties.Resources.search_icon;
            this.search.Location = new System.Drawing.Point(186, 10);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(37, 30);
            this.search.TabIndex = 0;
            this.search.UseCompatibleTextRendering = true;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.BackgroundImage = global::Movie_omdb.Properties.Resources.separator;
            this.pictureBox3.Location = new System.Drawing.Point(0, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(987, 14);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(987, 53);
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // actors
            // 
            this.actors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actors.Location = new System.Drawing.Point(78, 411);
            this.actors.Name = "actors";
            this.actors.Size = new System.Drawing.Size(208, 44);
            this.actors.TabIndex = 67;
            this.actors.Text = "-";
            // 
            // desc_17
            // 
            this.desc_17.AutoSize = true;
            this.desc_17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_17.Location = new System.Drawing.Point(3, 411);
            this.desc_17.Name = "desc_17";
            this.desc_17.Size = new System.Drawing.Size(50, 22);
            this.desc_17.TabIndex = 66;
            this.desc_17.Text = "Attori: ";
            this.desc_17.UseCompatibleTextRendering = true;
            // 
            // plot
            // 
            this.plot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plot.Location = new System.Drawing.Point(62, 461);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(224, 100);
            this.plot.TabIndex = 69;
            this.plot.Text = "-";
            // 
            // desc_18
            // 
            this.desc_18.AutoSize = true;
            this.desc_18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_18.Location = new System.Drawing.Point(3, 461);
            this.desc_18.Name = "desc_18";
            this.desc_18.Size = new System.Drawing.Size(59, 22);
            this.desc_18.TabIndex = 68;
            this.desc_18.Text = "Trama: ";
            this.desc_18.UseCompatibleTextRendering = true;
            // 
            // Omdb_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(987, 655);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.detail);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.details);
            this.Controls.Add(this.generic);
            this.Controls.Add(this.main);
            this.Controls.Add(this.poster);
            this.Controls.Add(this.search);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(762, 328);
            this.Name = "Omdb_main";
            this.Text = "Movie OMDB browser";
            this.Resize += new System.EventHandler(this.Omdb_main_Resize);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.detail.ResumeLayout(false);
            this.detail.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox ricerca;
        private System.Windows.Forms.Label generic;
        private System.Windows.Forms.Label details;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox poster;
        private System.Windows.Forms.Label searchtitle;
        private System.Windows.Forms.Label searchyear;
        private System.Windows.Forms.Label desc_m_3;
        private System.Windows.Forms.Label searchtype;
        private System.Windows.Forms.Label desc_m_2;
        private System.Windows.Forms.Label desc_m_1;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.Label rated;
        private System.Windows.Forms.Label year;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label desc_2;
        private System.Windows.Forms.Label desc_1;
        private System.Windows.Forms.Label desc_3;
        private System.Windows.Forms.Panel detail;
        private System.Windows.Forms.Button b_3;
        private System.Windows.Forms.Button b_4;
        private System.Windows.Forms.Button b_2;
        private System.Windows.Forms.Button b_5;
        private System.Windows.Forms.Button b_1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox searchlist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label desc_6;
        private System.Windows.Forms.Label genre;
        private System.Windows.Forms.Label desc_5;
        private System.Windows.Forms.Label runtime;
        private System.Windows.Forms.Label desc_4;
        private System.Windows.Forms.Label released;
        private System.Windows.Forms.Label desc_8;
        private System.Windows.Forms.Label desc_7;
        private System.Windows.Forms.Label writer;
        private System.Windows.Forms.Label director;
        private System.Windows.Forms.Label boxoffice;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label country;
        private System.Windows.Forms.Label language;
        private System.Windows.Forms.Label desc_12;
        private System.Windows.Forms.Label desc_10;
        private System.Windows.Forms.Label desc_11;
        private System.Windows.Forms.Label desc_9;
        private System.Windows.Forms.Label production;
        private System.Windows.Forms.Label dvd;
        private System.Windows.Forms.Label metascore;
        private System.Windows.Forms.Label awards;
        private System.Windows.Forms.Label desc_16;
        private System.Windows.Forms.Label desc_15;
        private System.Windows.Forms.Label desc_14;
        private System.Windows.Forms.Label desc_13;
        private System.Windows.Forms.Label actors;
        private System.Windows.Forms.Label desc_17;
        private System.Windows.Forms.Label plot;
        private System.Windows.Forms.Label desc_18;
    }
}