namespace Quiron.LojaVirtual.Dominio.Entidades
{
    public class EmailConfiguracoes
    {

        public int ServidorPorta = 994;
        public string ServidorSmtp = "smtp.quiron.com.br";
        public bool UsarSsl = false;
        public string Usuario = "quiron";
        public bool EscreverArquivo = false;
        public string PastaArquivo = @"c:\envioemail";
        public string De = "quiron.store@quiron.com.br";
        public string Para = "pedido@quiron.com.br";

    }
}