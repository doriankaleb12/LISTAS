class Nodo:
    def __init__(self, dato):
        self.dato = dato
        self.siguiente = None

def agregarNodo(cabeza, valor):
    nuevoNodo = Nodo(valor)

    if cabeza is None:
        cabeza = nuevoNodo
    else:
        actual = cabeza
        while actual.siguiente is not None:
            actual = actual.siguiente
        actual.siguiente = nuevoNodo

def imprimirLista(cabeza):
    actual = cabeza
    while actual is not None:
        print(actual.dato, end=" ")
        actual = actual.siguiente
    print()

def borrarLista(cabeza):
    while cabeza is not None:
        siguiente = cabeza.siguiente
        del cabeza
        cabeza = siguiente
        print("Elemento borrado")

def main():
    cabeza = None
    tamanolista = int(input("Ingrese la cantidad de elementos que desea agregar a la lista: "))

    if tamanolista <= 0:
        print("Cantidad de elementos no válida")
        return

    for i in range(tamanolista):
        valor = int(input(f"Ingrese dato {i + 1}: "))
        agregarNodo(cabeza, valor)

    print("Imprimiendo Lista de números")
    imprimirLista(cabeza)
    borrarLista(cabeza)

if __name__ == "__main__":
    main()

