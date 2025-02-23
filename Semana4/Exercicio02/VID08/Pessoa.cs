class Pessoa
{
    private string nome;

    public string Nome
    {
        get{return nome;} // obtem informação de um atributo
        set{nome=value;}  // envia informação para um atributo
        //para interagir com atributos não-publicos
    }

}