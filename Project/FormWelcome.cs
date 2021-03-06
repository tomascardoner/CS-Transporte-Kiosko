﻿using System;
using System.Windows.Forms;

namespace CSTransporteKiosko
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        public void SetAppearance(KioskoConfiguracion configuracion)
        {
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                TopLevel = true;
                TopMost = true;
            }

            Icon = Properties.Resources.ICON_APP;
            BackColor = CardonerSistemas.Colors.SetColor(configuracion.ValorScreenBackColor, this.BackColor);
            panelInicio.BackColor = CardonerSistemas.Colors.SetColor(configuracion.ValorScreenBackColor, panelInicio.BackColor);
            labelIniciar.ForeColor = CardonerSistemas.Colors.SetColor(configuracion.ValorInformacionPrincipalForeColor, labelIniciar.ForeColor);
            labelIniciar.Font = configuracion.ValorInformacionSecundariaFont;

            // Media
            mediaPlayer.uiMode = "none";
            mediaPlayer.URL = configuracion.ValorVideo;
        }

        private void mediaPlayer_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            Iniciar();
        }

        private void labelIniciar_Click(object sender, EventArgs e)
        {
            Iniciar();
        }

        private void Iniciar()
        {
            // Si se está ejecutando el video, lo detengo
            if (mediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                mediaPlayer.Ctlcontrols.stop();
            }
            this.Close();
        }

    }
}
