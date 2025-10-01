import random


def ejer04_sem06():
    #generar contraseña con tres intentos
    g=input("Genere contraseña: ")

    print()
    print("BIENVENIDO AL SISTEMA DE VALIDACIÓN DE CONTRASEÑA")
    print()
    print("1. Ud. tiene tres intentos")
    print()

    intentos=3
    while intentos>0:
        c=input("Ingrese su contraseña: ")
        print()
        if g==c:
            print("Acesso concebido. Bienvenido al sistema")
            break
        else:
            intentos-=1
            print(f"Contraseña incorrecta. Te quedan {intentos} intentos.")
    else: print("\nAcceso denegado.")

def ejer01_sem07():
    #en python no existe do-while.
    #qUE el usuario ingrese una serie de números y que el programa se detenga cuando se ingresa un número negativo.
    p=i=0

    while True:
        num=int(input("Ingrese un número entero: "))
        if num<0: break
        if num%2==0: p+=1
        else: i+=1

    print("\nCantidad de impares: ",p)
    print("Cantidad de pares: ",p)

def ejer02_sem07():
      #programa que haga que el usuario adivine el número between 1-20.
        import random

        print("BIENVENIDOS AL JUEGO ADIVINADOR")
        print("1. Ud. adivinará un número entre 1 y 20")
        print("2. Ud. tiene tres intentos")
        print("3- Ud. tendrá una pista por cada error")
        #en C# se le pone un número más o el número más uno para el segundo random
        secreto=random.randint(1,20)
        intentos=3

        while intentos>0:
            num=int(input("\nIngrese un número: "))  
            if num==secreto:
                print("\nAdivinaste el número.")
                break
            else: 
                intentos-=1
                if num>secreto:
                  print(f"\nPista: El número es menor. Le quedan {intentos} intentos")
        else:
           print(f"\nJuego terminado. No logró adivinar el número {secreto}")

def ejer03_sem07():
      suma=0
      while True:
         num=int(input("Ingrese un número entero: "))

         for i in range (1,num+1):
             print(i, end=" ")
             suma+=i
         print("\n\nLa suma es: ", suma)

         opc= input("Desea continuar?\n[S] Salir \n[C] Continuar")
         if opc=="s":
             break

ejer03_sem07()
  
