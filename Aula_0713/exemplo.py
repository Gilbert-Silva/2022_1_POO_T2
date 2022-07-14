try:
  print("Digite dois valores inteiros")
  x = int(input())
  y = int(input())
  z = x / y
  print(z)
except(ValueError):
  print("Valor informado não é inteiro")
except(ZeroDivisionError):
  print("Não pode dividir por zero")
finally:
  print("Sempre feito")
print("Cheguei aqui")  
