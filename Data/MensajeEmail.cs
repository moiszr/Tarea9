using System.Net.Mail;
namespace Tarea9.Data
{
    public class MensajeEmail
    {
        public void Correo(Cliente client)
        {
            string EmailOrigen = "tempmois23@gmail.com";
            string EmailDestino = client.Email!;
            string Contraseña = "omewyyeibfdryxro";

            string Titulo = "Copia de los Datos Registrados";

            MailMessage mailMessage = new MailMessage(EmailOrigen, EmailDestino, Titulo, MensajeCorreo(client));

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com");
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            //smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.Credentials = new System.Net.NetworkCredential(EmailOrigen, Contraseña);


            smtpClient.Send(mailMessage);

            smtpClient.Dispose();
        }

        private string MensajeCorreo(Cliente client)
        {
            string mensaje = $"Distinguido {client.Nombre + " " + client.Apellido}, nos place anunciarle que sus datos han sido registrados satisfactoriamente" +
                $"Copia de la Informacion Registrada. \n\n" +
                $"Cédula: {client.Cedula} \n" +
                $"Nombre: {client.Nombre} \n" +
                $"Apellido: {client.Apellido} \n" +
                $"Teléfoono: {client.Telefono} \n" +
                $"Correo Electronico: {client.Email} \n" +
                $"Fecha de Nacimiento: {client.FechaNacimiento.ToString("dd/mm/yyyy")} \n" +
                $"Tipo de Sangre: {client.TipoSangre} \n" +
                $"Provincia: {client.Provincia} \n" +
                $"Dirección: {client.Direccion} \n" +
                $"Latitud: {client.Latitude} \n" +
                $"Longitud: {client.Longitude} \n" +
                $"¿Le ha dado Covid?: {client.lehadadocovid} \n" +
                $"Justificacion: {client.Justificacion} \n";

            return mensaje;
        }
    }
}
