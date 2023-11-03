using Newtonsoft.Json;

namespace stock_web.Models;

public enum TipoMensagem
{
    Informacao,
    Erro
}

public class MensagemModel
{
    public TipoMensagem Tipo { get; set; }
    public string TextoMensagem { get; set; }

    public MensagemModel(string texto, TipoMensagem tipo = TipoMensagem.Informacao)
    {
        this.TextoMensagem = texto;
        this.Tipo = tipo;
    }

    public static string SerializarMensagem(string mensagem, TipoMensagem tipo = TipoMensagem.Informacao)
    {
        var mensagemModel = new MensagemModel(mensagem, tipo);
        return JsonConvert.SerializeObject(mensagemModel);
    }

    public static MensagemModel DesserializarMensagem(string mensagemString)
    {
        return JsonConvert.DeserializeObject<MensagemModel>(mensagemString) ?? 
        new MensagemModel("Erro ao desserializar", TipoMensagem.Erro);
    }
}