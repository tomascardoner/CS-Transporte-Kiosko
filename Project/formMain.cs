﻿using System;
using System.Windows.Forms;

namespace CSTransporteKiosk
{
    public partial class formMain : Form
    {
        #region "Declarations"
        byte pasoActual = 0;
        Boolean porDNI;

        CardonerSistemas.Database_ADO_SQLServer mDatabase;

        DateTime logoFirstClickTime = new DateTime(0);
        DateTime logoSecondClickTime = new DateTime(0);
        #endregion

        #region "Form stuff"

          public formMain()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            prepararConexionABaseDeDatos();
            setAppearance();
            mostrarPasos();
        }

        private void prepararConexionABaseDeDatos()
        {
            mDatabase = new CardonerSistemas.Database_ADO_SQLServer();
            mDatabase.applicationName = CardonerSistemas.My.Application.Info.Title;
            mDatabase.datasource = ThisMachine.Default.DatabaseDatasource;
            mDatabase.initialCatalog = ThisMachine.Default.DatabaseDatabase;
            mDatabase.userID = ThisMachine.Default.DatabaseUserID;
            if (ThisMachine.Default.DatabasePassword.Trim().Length == 0)
            {
                mDatabase.password = "";
            }
            else
            {
                CardonerSistemas.Encrypt_TripleDES decrypter = new CardonerSistemas.Encrypt_TripleDES(CardonerSistemas.Constants.PublicEncryptionPassword);
                string decryptedPassword = "";
                if (decrypter.Decrypt(ThisMachine.Default.DatabasePassword, ref decryptedPassword))
                {
                    mDatabase.password = decryptedPassword;
                }
                decrypter = null;
            }
            mDatabase.workstationID = "";
            mDatabase.CreateConnectionString();
        }

        private void setAppearance()
        {
            pictureboxLogoEmpresa.ImageLocation = Properties.Settings.Default.EmpresaLogotipo;
            wmInicio_Player.uiMode = "none";
            wmInicio_Player.URL = Properties.Settings.Default.EmpresaVideo;

            // Version del assembly
            labelPasosVersion.Text = CardonerSistemas.My.Application.Info.Version.ToString();
            pictureboxPasosLogoCompaniaSoftware.ImageLocation = Properties.Settings.Default.CompaniaSoftwareLogotipo;

            // Propiedades del teclado numérico en pantalla
            onscreenkeyboardDNI.Font = Properties.Settings.Default.KeyboardNumericNumberFont;
        }

        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (mDatabase.connection.State != System.Data.ConnectionState.Open)
                {
                    mDatabase.connection.Close();
                    mDatabase = null;
                }
            }
            catch (Exception)
            {
                mDatabase = null;
            }
        }

        #endregion

        #region "Controls stuff"

        private void KeyCombinationManager(object sender, KeyEventArgs e)
        {
            if ((e.Control && e.KeyCode == Keys.X) || (e.Alt && e.KeyCode == Keys.X))  // Control + X or Alt + X
            {
                Application.Exit();
            }
        }

        private void wmPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                wmInicio_Player.Ctlcontrols.stop();
                wmInicio_Player.Ctlcontrols.play();
            }
        }

        private void Click_ToStart()
        {
            if (pasoActual == 0)
            {
                if (wmInicio_Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
                {
                    wmInicio_Player.Ctlcontrols.stop();
                }
            }
        }

        private void Click_ToStart(object sender, MouseEventArgs e)
        {
            Click_ToStart();
            AvanzarPaso();
        }

        private void Click_ToStart(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            Click_ToStart();
            AvanzarPaso();
        }

        private void ButtonPasoSiguiente_Click(object sender, EventArgs e)
        {
            AvanzarPaso();
        }

        private void ButtonPasoAnterior_Click(object sender, EventArgs e)
        {
            RetrocederPaso();
        }

        private void SoftwareCompanyClick(object sender, EventArgs e)
        {
            if (logoFirstClickTime.Ticks == 0)
            {
                logoFirstClickTime = DateTime.Now;
            }
            else
            {
                if (logoSecondClickTime.Ticks == 0)
                {

                }
            }
        }

        #endregion

        #region "Pasos stuff"

        private void AvanzarPaso()
        {
            switch (pasoActual)
            {
                case 1:
                    if (radioPaso1_DNI.Checked == false & radioPaso1_Reserva.Checked == false)
                    {
                        MessageBox.Show("Debe seleccionar alguna de las dos opciones.");
                        return;
                    }
                    porDNI = (radioPaso1_DNI.Checked);
                    if (porDNI)
                    {
                        labelPaso2_DNI_Reserva.Text = "Ingrese el D.N.I.:";
                    }
                    else
                    {
                        labelPaso2_DNI_Reserva.Text = "Ingrese el Número de Reserva:";
                    }
                    break;

                case 2:
                    if (porDNI)
                    {
                        if (textboxPaso2_DNI_Reserva.Text.Trim().Length < 6)
                        {
                            MessageBox.Show("EL D.N.I. debe contener al menos 6 (seis) dígitos.");
                            return;
                        }
                    }
                    else
                    {
                        if (textboxPaso2_DNI_Reserva.Text.Trim().Length < 8)
                        {
                            MessageBox.Show("Debe ingresar los 8 (ocho) caracteres del número de reserva.");
                            return;
                        }
                    }
                    break;

                default:
                    break;
            }

            pasoActual++;
            mostrarPasos();
        }

        private void RetrocederPaso()
        {
            pasoActual--;
            mostrarPasos();
        }

        private void mostrarPasos()
        {
            switch (pasoActual)
            {
                case 1:
                    radioPaso1_DNI.Checked = false;
                    radioPaso1_Reserva.Checked = false;
                    break;
                case 2:
                    textboxPaso2_DNI_Reserva.Text = "";
                    break;
                default:
                    break;
            }
            panelInicio.Visible = (pasoActual == 0);
            panelPasos.Visible = (pasoActual > 0);
            panelPaso1.Visible = (pasoActual == 1);
            panelPaso2.Visible = (pasoActual == 2);
            buttonPasoAnterior.Visible = (pasoActual > 0);
            buttonPasoSiguiente.Visible = (pasoActual > 0);
        }

        #endregion

        private bool ConnectToDatabase()
        {
            if (mDatabase.connection == null || mDatabase.connection.State != System.Data.ConnectionState.Open)
            {
                return mDatabase.Connect();
            }
            else
            {
                return true;
            }
        }
    }
}
