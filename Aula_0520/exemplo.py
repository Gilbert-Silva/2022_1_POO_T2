class ContaBancaria:
  pass

a = ContaBancaria()
b = ContaBancaria()
c = a

print(id(a))
print(id(b))
print(id(c))
print(a)
print(b)
print(c)
