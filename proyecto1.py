def ejer1():
    edad=int(input("INGRESE SU EDAD: "))
    print()
    if edad>=18:
        print("APTO PARA VOTAR")
        if edad>=25:
            print("PUEDES SER CANDIDATO A UN CARGO POLÍTICO")
        else:
            print("NO PUEDES SER CANDIDATO A UN CARGO POLÍTICO")
    else:
         print("NO PUEDES VOTAR")

def ejer2():
    lad1=int(input("Ingrese lado 1: "))
    lad2=int(input("Ingrese lado 2: "))
    lad3=int(input("Ingrese lado 3: "))

    print()

    if lad1==lad2==lad3:
        print ("EQUILATERO")
    elif lad1==lad3 or lad2==lad3 or lad1==lad2:
        print("ISOSCELES")
    else:
        print("ESCALENO")

def ejer3():
    n=int(input("Ingrese un número entero: "))
    suma=0
    print()

    for i in range(1, n+1):
        print(i)
    
        if(i%2==0):
            suma+=i
    print("\nSuma de pares: ", suma)

def ejer4():
    cantidad=int(input("Ingrese una cantidad: "))
    par = impar = cero = 0
    
    print()

    for i in range (1,cantidad+1):
        num=int(input(f"Ingrese número {i}: "))
        
        if num==0:
           cero+=1
        elif num%2==0:
            par+=1
        else:
            impar+=1

print("\nCantidad de pares: ", par)
print("Cantidad de impares: ", impar)
print("Cantidad de ceros: ", cero)

ejer4()