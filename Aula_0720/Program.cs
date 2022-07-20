using System;

class Program {
  public static void Main() {
    Console.WriteLine("--- Bem-vindo ao IFShop ---");
    int op;
    do {
      op = Menu();
      switch(op) {
        case 01 : CategoriaInserir(); break;
        case 02 : CategoriaListar(); break;
        case 03 : CategoriaAtualizar(); break;
        case 04 : CategoriaExcluir(); break;  
      }
    } while (op != 99);  
  }
  public static int Menu() {
    Console.WriteLine("----- Categorias -----");
    Console.WriteLine("  01 - Inserir");
    Console.WriteLine("  02 - Listar");
    Console.WriteLine("  03 - Atualizar");
    Console.WriteLine("  04 - Excluir");
    Console.WriteLine("----------------------");
    Console.WriteLine("  99 - Fim");
    Console.WriteLine("----------------------");
    Console.Write("Opção: ");
    return int.Parse(Console.ReadLine());
  }
  public static void CategoriaInserir() {
    Console.WriteLine("Categoria Inserir");
    Categoria c = new Categoria();
    c.Id = 1;
    c.Descricao = "Mouse";
    Console.WriteLine(c);
  }
  public static void CategoriaListar() {
    Console.WriteLine("Categoria Listar");
  }
  public static void CategoriaAtualizar() {
    Console.WriteLine("Categoria Atualizar");
  }
  public static void CategoriaExcluir() {
    Console.WriteLine("Categoria Excluir");
  }
}