﻿namespace CSTransporteKiosk
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panelPasos = new System.Windows.Forms.TableLayoutPanel();
            this.pictureboxLogoEmpresa = new System.Windows.Forms.PictureBox();
            this.panelUser = new System.Windows.Forms.Panel();
            this.panelPaso2 = new System.Windows.Forms.TableLayoutPanel();
            this.textboxPaso2_DNI_Reserva = new System.Windows.Forms.TextBox();
            this.labelPaso2_DNI_Reserva = new System.Windows.Forms.Label();
            this.onscreenkeyboardDNI = new CSTransporteKiosk.CS_Control_OnScreenKeyboard_Numeric();
            this.panelPaso1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioPaso1_DNI = new System.Windows.Forms.RadioButton();
            this.radioPaso1_Reserva = new System.Windows.Forms.RadioButton();
            this.panelPasosNavegacion = new System.Windows.Forms.TableLayoutPanel();
            this.buttonPasoAnterior = new System.Windows.Forms.Button();
            this.buttonPasoSiguiente = new System.Windows.Forms.Button();
            this.panelPasosPie = new System.Windows.Forms.TableLayoutPanel();
            this.labelPasosVersion = new System.Windows.Forms.Label();
            this.pictureboxPasosLogoCompaniaSoftware = new System.Windows.Forms.PictureBox();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.panelInicio = new System.Windows.Forms.TableLayoutPanel();
            this.labelInicio_LeyendaIniciar = new System.Windows.Forms.Label();
            this.wmInicio_Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelPaso3 = new System.Windows.Forms.TableLayoutPanel();
            this.listviewPaso3Pasajeros = new System.Windows.Forms.ListView();
            this.panelPasos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogoEmpresa)).BeginInit();
            this.panelUser.SuspendLayout();
            this.panelPaso2.SuspendLayout();
            this.panelPaso1.SuspendLayout();
            this.panelPasosNavegacion.SuspendLayout();
            this.panelPasosPie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPasosLogoCompaniaSoftware)).BeginInit();
            this.panelInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmInicio_Player)).BeginInit();
            this.panelPaso3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPasos
            // 
            this.panelPasos.ColumnCount = 1;
            this.panelPasos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPasos.Controls.Add(this.pictureboxLogoEmpresa, 0, 0);
            this.panelPasos.Controls.Add(this.panelUser, 0, 1);
            this.panelPasos.Controls.Add(this.panelPasosNavegacion, 0, 2);
            this.panelPasos.Controls.Add(this.panelPasosPie, 0, 3);
            this.panelPasos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPasos.Location = new System.Drawing.Point(0, 0);
            this.panelPasos.Name = "panelPasos";
            this.panelPasos.RowCount = 4;
            this.panelPasos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelPasos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.panelPasos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.panelPasos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.panelPasos.Size = new System.Drawing.Size(800, 600);
            this.panelPasos.TabIndex = 4;
            // 
            // pictureboxLogoEmpresa
            // 
            this.pictureboxLogoEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureboxLogoEmpresa.Location = new System.Drawing.Point(3, 3);
            this.pictureboxLogoEmpresa.Name = "pictureboxLogoEmpresa";
            this.pictureboxLogoEmpresa.Size = new System.Drawing.Size(794, 94);
            this.pictureboxLogoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureboxLogoEmpresa.TabIndex = 1;
            this.pictureboxLogoEmpresa.TabStop = false;
            this.pictureboxLogoEmpresa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_ToStart);
            // 
            // panelUser
            // 
            this.panelUser.Controls.Add(this.panelPaso3);
            this.panelUser.Controls.Add(this.panelPaso2);
            this.panelUser.Controls.Add(this.panelPaso1);
            this.panelUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUser.Location = new System.Drawing.Point(3, 103);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(794, 344);
            this.panelUser.TabIndex = 4;
            // 
            // panelPaso2
            // 
            this.panelPaso2.ColumnCount = 4;
            this.panelPaso2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPaso2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelPaso2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelPaso2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPaso2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelPaso2.Controls.Add(this.textboxPaso2_DNI_Reserva, 2, 1);
            this.panelPaso2.Controls.Add(this.labelPaso2_DNI_Reserva, 1, 1);
            this.panelPaso2.Controls.Add(this.onscreenkeyboardDNI, 3, 2);
            this.panelPaso2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaso2.Location = new System.Drawing.Point(0, 0);
            this.panelPaso2.Name = "panelPaso2";
            this.panelPaso2.RowCount = 3;
            this.panelPaso2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPaso2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelPaso2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPaso2.Size = new System.Drawing.Size(794, 344);
            this.panelPaso2.TabIndex = 6;
            this.panelPaso2.Visible = false;
            // 
            // textboxPaso2_DNI_Reserva
            // 
            this.textboxPaso2_DNI_Reserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textboxPaso2_DNI_Reserva.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textboxPaso2_DNI_Reserva.Enabled = false;
            this.textboxPaso2_DNI_Reserva.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.textboxPaso2_DNI_Reserva.Location = new System.Drawing.Point(452, 154);
            this.textboxPaso2_DNI_Reserva.MaxLength = 8;
            this.textboxPaso2_DNI_Reserva.Name = "textboxPaso2_DNI_Reserva";
            this.textboxPaso2_DNI_Reserva.Size = new System.Drawing.Size(150, 35);
            this.textboxPaso2_DNI_Reserva.TabIndex = 2;
            this.textboxPaso2_DNI_Reserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelPaso2_DNI_Reserva
            // 
            this.labelPaso2_DNI_Reserva.AutoSize = true;
            this.labelPaso2_DNI_Reserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPaso2_DNI_Reserva.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelPaso2_DNI_Reserva.Location = new System.Drawing.Point(191, 151);
            this.labelPaso2_DNI_Reserva.Name = "labelPaso2_DNI_Reserva";
            this.labelPaso2_DNI_Reserva.Size = new System.Drawing.Size(255, 41);
            this.labelPaso2_DNI_Reserva.TabIndex = 1;
            this.labelPaso2_DNI_Reserva.Text = "Ingrese el DNI / Reserva:";
            this.labelPaso2_DNI_Reserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // onscreenkeyboardDNI
            // 
            this.onscreenkeyboardDNI.DestinationTextBox = this.textboxPaso2_DNI_Reserva;
            this.onscreenkeyboardDNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onscreenkeyboardDNI.Location = new System.Drawing.Point(608, 195);
            this.onscreenkeyboardDNI.Name = "onscreenkeyboardDNI";
            this.onscreenkeyboardDNI.Size = new System.Drawing.Size(183, 146);
            this.onscreenkeyboardDNI.TabIndex = 3;
            // 
            // panelPaso1
            // 
            this.panelPaso1.ColumnCount = 3;
            this.panelPaso1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPaso1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelPaso1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPaso1.Controls.Add(this.radioPaso1_DNI, 1, 1);
            this.panelPaso1.Controls.Add(this.radioPaso1_Reserva, 1, 3);
            this.panelPaso1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaso1.Location = new System.Drawing.Point(0, 0);
            this.panelPaso1.Name = "panelPaso1";
            this.panelPaso1.RowCount = 5;
            this.panelPaso1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelPaso1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelPaso1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelPaso1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelPaso1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelPaso1.Size = new System.Drawing.Size(794, 344);
            this.panelPaso1.TabIndex = 3;
            this.panelPaso1.Visible = false;
            // 
            // radioPaso1_DNI
            // 
            this.radioPaso1_DNI.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPaso1_DNI.AutoSize = true;
            this.radioPaso1_DNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioPaso1_DNI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioPaso1_DNI.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioPaso1_DNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioPaso1_DNI.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.radioPaso1_DNI.Location = new System.Drawing.Point(224, 71);
            this.radioPaso1_DNI.Name = "radioPaso1_DNI";
            this.radioPaso1_DNI.Size = new System.Drawing.Size(345, 62);
            this.radioPaso1_DNI.TabIndex = 7;
            this.radioPaso1_DNI.TabStop = true;
            this.radioPaso1_DNI.Text = "Ingresar con D.N.I.";
            this.radioPaso1_DNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioPaso1_DNI.UseVisualStyleBackColor = false;
            // 
            // radioPaso1_Reserva
            // 
            this.radioPaso1_Reserva.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioPaso1_Reserva.AutoSize = true;
            this.radioPaso1_Reserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.radioPaso1_Reserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioPaso1_Reserva.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.radioPaso1_Reserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioPaso1_Reserva.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.radioPaso1_Reserva.Location = new System.Drawing.Point(224, 207);
            this.radioPaso1_Reserva.Name = "radioPaso1_Reserva";
            this.radioPaso1_Reserva.Size = new System.Drawing.Size(345, 62);
            this.radioPaso1_Reserva.TabIndex = 6;
            this.radioPaso1_Reserva.TabStop = true;
            this.radioPaso1_Reserva.Text = "Ingresar con Número de Reserva";
            this.radioPaso1_Reserva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioPaso1_Reserva.UseVisualStyleBackColor = false;
            // 
            // panelPasosNavegacion
            // 
            this.panelPasosNavegacion.ColumnCount = 5;
            this.panelPasosNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelPasosNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelPasosNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.panelPasosNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelPasosNavegacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.panelPasosNavegacion.Controls.Add(this.buttonPasoAnterior, 1, 0);
            this.panelPasosNavegacion.Controls.Add(this.buttonPasoSiguiente, 3, 0);
            this.panelPasosNavegacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPasosNavegacion.Location = new System.Drawing.Point(3, 453);
            this.panelPasosNavegacion.Name = "panelPasosNavegacion";
            this.panelPasosNavegacion.RowCount = 1;
            this.panelPasosNavegacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPasosNavegacion.Size = new System.Drawing.Size(794, 44);
            this.panelPasosNavegacion.TabIndex = 6;
            // 
            // buttonPasoAnterior
            // 
            this.buttonPasoAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonPasoAnterior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPasoAnterior.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonPasoAnterior.Location = new System.Drawing.Point(23, 3);
            this.buttonPasoAnterior.Name = "buttonPasoAnterior";
            this.buttonPasoAnterior.Size = new System.Drawing.Size(144, 38);
            this.buttonPasoAnterior.TabIndex = 3;
            this.buttonPasoAnterior.Text = "Anterior";
            this.buttonPasoAnterior.UseVisualStyleBackColor = false;
            this.buttonPasoAnterior.Click += new System.EventHandler(this.ButtonPasoAnterior_Click);
            // 
            // buttonPasoSiguiente
            // 
            this.buttonPasoSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonPasoSiguiente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPasoSiguiente.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonPasoSiguiente.Location = new System.Drawing.Point(623, 3);
            this.buttonPasoSiguiente.Name = "buttonPasoSiguiente";
            this.buttonPasoSiguiente.Size = new System.Drawing.Size(144, 38);
            this.buttonPasoSiguiente.TabIndex = 2;
            this.buttonPasoSiguiente.Text = "Siguiente";
            this.buttonPasoSiguiente.UseVisualStyleBackColor = false;
            this.buttonPasoSiguiente.Click += new System.EventHandler(this.ButtonPasoSiguiente_Click);
            // 
            // panelPasosPie
            // 
            this.panelPasosPie.ColumnCount = 3;
            this.panelPasosPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelPasosPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPasosPie.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.panelPasosPie.Controls.Add(this.labelPasosVersion, 0, 1);
            this.panelPasosPie.Controls.Add(this.pictureboxPasosLogoCompaniaSoftware, 2, 1);
            this.panelPasosPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPasosPie.Location = new System.Drawing.Point(3, 503);
            this.panelPasosPie.Name = "panelPasosPie";
            this.panelPasosPie.RowCount = 2;
            this.panelPasosPie.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelPasosPie.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.panelPasosPie.Size = new System.Drawing.Size(794, 94);
            this.panelPasosPie.TabIndex = 7;
            // 
            // labelPasosVersion
            // 
            this.labelPasosVersion.AutoSize = true;
            this.labelPasosVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPasosVersion.Location = new System.Drawing.Point(3, 30);
            this.labelPasosVersion.Name = "labelPasosVersion";
            this.labelPasosVersion.Size = new System.Drawing.Size(41, 64);
            this.labelPasosVersion.TabIndex = 1;
            this.labelPasosVersion.Text = "version";
            this.labelPasosVersion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureboxPasosLogoCompaniaSoftware
            // 
            this.pictureboxPasosLogoCompaniaSoftware.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureboxPasosLogoCompaniaSoftware.Location = new System.Drawing.Point(641, 33);
            this.pictureboxPasosLogoCompaniaSoftware.Name = "pictureboxPasosLogoCompaniaSoftware";
            this.pictureboxPasosLogoCompaniaSoftware.Size = new System.Drawing.Size(150, 58);
            this.pictureboxPasosLogoCompaniaSoftware.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureboxPasosLogoCompaniaSoftware.TabIndex = 0;
            this.pictureboxPasosLogoCompaniaSoftware.TabStop = false;
            this.pictureboxPasosLogoCompaniaSoftware.Click += new System.EventHandler(this.SoftwareCompanyClick);
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            // 
            // panelInicio
            // 
            this.panelInicio.ColumnCount = 1;
            this.panelInicio.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelInicio.Controls.Add(this.labelInicio_LeyendaIniciar, 0, 1);
            this.panelInicio.Controls.Add(this.wmInicio_Player, 0, 0);
            this.panelInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicio.Location = new System.Drawing.Point(0, 0);
            this.panelInicio.Name = "panelInicio";
            this.panelInicio.RowCount = 2;
            this.panelInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelInicio.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.panelInicio.Size = new System.Drawing.Size(800, 600);
            this.panelInicio.TabIndex = 5;
            this.panelInicio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_ToStart);
            // 
            // labelInicio_LeyendaIniciar
            // 
            this.labelInicio_LeyendaIniciar.AutoSize = true;
            this.labelInicio_LeyendaIniciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInicio_LeyendaIniciar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInicio_LeyendaIniciar.Location = new System.Drawing.Point(3, 550);
            this.labelInicio_LeyendaIniciar.Name = "labelInicio_LeyendaIniciar";
            this.labelInicio_LeyendaIniciar.Size = new System.Drawing.Size(794, 50);
            this.labelInicio_LeyendaIniciar.TabIndex = 4;
            this.labelInicio_LeyendaIniciar.Text = "Toque la pantalla para comenzar";
            this.labelInicio_LeyendaIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInicio_LeyendaIniciar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_ToStart);
            // 
            // wmInicio_Player
            // 
            this.wmInicio_Player.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmInicio_Player.Enabled = true;
            this.wmInicio_Player.Location = new System.Drawing.Point(3, 3);
            this.wmInicio_Player.Name = "wmInicio_Player";
            this.wmInicio_Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmInicio_Player.OcxState")));
            this.wmInicio_Player.Size = new System.Drawing.Size(794, 544);
            this.wmInicio_Player.TabIndex = 1;
            this.wmInicio_Player.ClickEvent += new AxWMPLib._WMPOCXEvents_ClickEventHandler(this.Click_ToStart);
            // 
            // panelPaso3
            // 
            this.panelPaso3.ColumnCount = 3;
            this.panelPaso3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelPaso3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPaso3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.panelPaso3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelPaso3.Controls.Add(this.listviewPaso3Pasajeros, 1, 0);
            this.panelPaso3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaso3.Location = new System.Drawing.Point(0, 0);
            this.panelPaso3.Name = "panelPaso3";
            this.panelPaso3.RowCount = 1;
            this.panelPaso3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelPaso3.Size = new System.Drawing.Size(794, 344);
            this.panelPaso3.TabIndex = 7;
            this.panelPaso3.Visible = false;
            // 
            // listviewPaso3Pasajeros
            // 
            this.listviewPaso3Pasajeros.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listviewPaso3Pasajeros.CheckBoxes = true;
            this.listviewPaso3Pasajeros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewPaso3Pasajeros.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listviewPaso3Pasajeros.HideSelection = false;
            this.listviewPaso3Pasajeros.LabelWrap = false;
            this.listviewPaso3Pasajeros.Location = new System.Drawing.Point(33, 3);
            this.listviewPaso3Pasajeros.MultiSelect = false;
            this.listviewPaso3Pasajeros.Name = "listviewPaso3Pasajeros";
            this.listviewPaso3Pasajeros.ShowGroups = false;
            this.listviewPaso3Pasajeros.Size = new System.Drawing.Size(728, 338);
            this.listviewPaso3Pasajeros.TabIndex = 0;
            this.listviewPaso3Pasajeros.UseCompatibleStateImageBehavior = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panelPasos);
            this.Controls.Add(this.panelInicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyCombinationManager);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click_ToStart);
            this.panelPasos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxLogoEmpresa)).EndInit();
            this.panelUser.ResumeLayout(false);
            this.panelPaso2.ResumeLayout(false);
            this.panelPaso2.PerformLayout();
            this.panelPaso1.ResumeLayout(false);
            this.panelPaso1.PerformLayout();
            this.panelPasosNavegacion.ResumeLayout(false);
            this.panelPasosPie.ResumeLayout(false);
            this.panelPasosPie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxPasosLogoCompaniaSoftware)).EndInit();
            this.panelInicio.ResumeLayout(false);
            this.panelInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmInicio_Player)).EndInit();
            this.panelPaso3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel panelPasos;
        private System.Windows.Forms.PictureBox pictureboxLogoEmpresa;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.TableLayoutPanel panelPaso1;
        private System.Windows.Forms.TableLayoutPanel panelPasosNavegacion;
        private System.Windows.Forms.Button buttonPasoSiguiente;
        private System.Windows.Forms.Button buttonPasoAnterior;
        private System.Windows.Forms.TableLayoutPanel panelPasosPie;
        private System.Windows.Forms.Label labelPasosVersion;
        private System.Windows.Forms.TableLayoutPanel panelInicio;
        private System.Windows.Forms.Label labelInicio_LeyendaIniciar;
        private AxWMPLib.AxWindowsMediaPlayer wmInicio_Player;
        private System.Windows.Forms.TableLayoutPanel panelPaso2;
        private System.Windows.Forms.Label labelPaso2_DNI_Reserva;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.RadioButton radioPaso1_DNI;
        private System.Windows.Forms.RadioButton radioPaso1_Reserva;
        private System.Windows.Forms.PictureBox pictureboxPasosLogoCompaniaSoftware;
        private CS_Control_OnScreenKeyboard_Numeric onscreenkeyboardDNI;
        private System.Windows.Forms.TextBox textboxPaso2_DNI_Reserva;
        private System.Windows.Forms.TableLayoutPanel panelPaso3;
        private System.Windows.Forms.ListView listviewPaso3Pasajeros;
    }
}

