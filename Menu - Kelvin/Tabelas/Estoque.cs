using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu___Kelvin.Tabelas
{
    internal class Estoque
    {
        public string produto {  get; set; }
        public string unidade { get; set; }
        public string precoCusto { get; set; }
        public string precoVenda { get; set; }
        public decimal percLucro { get; set; }
        public string iat {  get; set; }
        public string ippt { get; set; }
        public string tributado { get; set; }
        public string pesado { get; set; }
        public int codUnidaDeMedida {  get; set; }
        public int codCstOrigem { get; set; }
        public string fatorConversao { get; set; }
        public string ncm {  get; set; }
        public string referencia { get; set; }
        public string codBarras { get; set; }
        public string csosn {  get; set; }
        public string cstIpi { get; set; }
        public string cstPis { get; set; }
        public string cstCofins { get; set; }
        public string aliquotaIcms { get; set; }
        public string qtdeInicial { get; set; }
    }
}
