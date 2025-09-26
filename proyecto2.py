def ejer1():
    num=int(input("Ingrese número: "))

    while num<=0:
        num=int(input("ERROR: Ingrese número: "))

    i=1
    print()

    while i<=12:
        print(f"{num} * {i}={num*i}")
        i+=1
    print()
 


def ejer2():
    sumaP=sumaI=0
    while True:
     New=int(input("Ingrese un numero(0): "))

     if New==0:
         break

     if New<0:
         print("ERROR. Ingrese un numero negativo: ")
         continue

     if New%2==0:
         sumaP+=New
     else:
         sumaI+=New

    print("\nSuma de pares: ", sumaP)
    print("Suma de impares: ", sumaI)


def ejer3():
    filas=int(input("Ingrese cantidad de filas: "))
    columnas=int(input("Ingrese cantidad de columnas: "))
    print()
    i=1

    while i<=filas:
        j=1
        while j<=columnas:
            print("*", end=" ") #para evadir el salto de line es end=" "
            j+=1
        print()
        i+=1
