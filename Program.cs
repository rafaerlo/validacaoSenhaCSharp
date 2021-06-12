using System;

class MinhaClasse {
  public static void Main (string[] args) {

    string senha = Console.ReadLine();
    int tamanho = senha.Length;

    string[] arr1 = {"1","2","3","4","5","6","7","8","9","0"};
    string[] arr2 = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
    string[] arr3 = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

    int match = 0;

    if(senha.Length>=6 && senha.Length<=32){
      //Substitui numero por vazio
      for(int i=0; i<arr1.Length; i++){
        senha=senha.Replace(arr1[i],"");
      }

      //valida tamanho
      if(tamanho!=senha.Length){
        match++;
        tamanho=senha.Length;
      }

      //Substitui letra minuscula por vazio
      for(int i=0; i<arr2.Length; i++){
        senha=senha.Replace(arr2[i],"");
      }

      //valida tamanho
      if(tamanho!=senha.Length){
        match++;
        tamanho=senha.Length;
      }

      //Substitui letra maiuscula por vazio
      for(int i=0; i<arr3.Length; i++){
        senha=senha.Replace(arr3[i],"");
      }

      //valida tamanho
      if(tamanho!=senha.Length){
        match++;
        tamanho=senha.Length;
      }
    }

    if((match==3) && (tamanho==0)){
      Console.WriteLine("Senha valida");
    }else{
      Console.WriteLine("Senha invalida");
    }
  }
}