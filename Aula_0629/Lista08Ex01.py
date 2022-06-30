from datetime import datetime

class Aluno:
  def __init__(self, nome, matricula, nascimento):
    self.__nome = nome
    self.__matricula = matricula
    self.__nascimento = nascimento

  @property
  def Nome(self):
    return self.__nome

  @property
  def Nascimento(self):
    return self.__nascimento
    
  def __str__(self):
    data = self.__nascimento.strftime("%d/%m/%Y")
    return f"{self.__nome} - {self.__matricula} - {data}"

  @staticmethod
  def orderNome(aluno):
    return aluno.Nome

  @staticmethod
  def orderNascimento(aluno):
    return aluno.Nascimento

if __name__ == "__main__":
  data = datetime.strptime("29/06/2022", "%d/%m/%Y")
  a1 = Aluno("Gilbert", "1234", data)
  data = datetime.strptime("29/05/2021", "%d/%m/%Y")
  a2 = Aluno("Eduardo", "4321", data)
  data = datetime.strptime("20/05/2021", "%d/%m/%Y")
  a3 = Aluno("Jorgiano", "1212", data)

  x = [5, 4, 1, 2]
  print(x)
  x.sort()
  print(x)
  print()
  
  lista = [a1, a2, a3]
  for a in lista: print(a)
  print()
  lista.sort(key = Aluno.orderNome)  
  for a in lista: print(a)
  print()
  lista.sort(key = Aluno.orderNascimento)  
  for a in lista: print(a)
  