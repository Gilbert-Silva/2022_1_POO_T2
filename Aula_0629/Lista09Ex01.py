class Historico:
  def __init__(self):
    self.__disciplinas = []

  def imprimir(self):
    for d in self.__disciplinas:
      print(f"{d.GetNome()} - {d.CalcMediaFinal()}")

  def inserir(self, d):
    self.__disciplinas.append(d)

if __name__ == "__main__":
  h = Historico()
  print(h)
  h.inserir("teste")
  h.imprimir()
  