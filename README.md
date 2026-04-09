# Calculadora-Con-Delegados

## Explicación del problema
En esta actividad se nos pidió desarrollar una aplicación en consola que pueda realizar operaciones matemáticas básicas, pero utilizando delegados en lugar de estructuras tradicionales como if o switch. La idea principal es que el programa sea dinámico, que pueda ejecutar diferentes operaciones dependiendo de la opción que el usuario elija.

## Definición de delegados
Un delegado en C# es un tipo que permite almacenar referencias a métodos. Es como una variable que puede apuntar a diferentes funciones siempre que tengan la misma estructura. Gracias a los delegados, se puede ejecutar un método de forma indirecta, lo que hace el código más flexible.

## ¿Por qué usar delegados en vez de llamar métodos directamente?
En mi opinión, usar delegados es mejor porque permite que el programa sea más organizado y escalable. En lugar de tener muchos if o switch para decidir qué método ejecutar, simplemente se asigna el método a un delegado y se ejecuta. Y si es necesario agregar una nueva operación, solo hay que añadirla al diccionario sin modificar la lógica principal del programa esto hace que el código sea más limpio y fácil de mantener.

## Cómo se implementaron en el proyecto  
Para realizar este programa seguí estos pasos:

1- Definí un delegado que recibe dos números enteros y devuelve un entero.
2- Creé los métodos para cada operación matemática.
3- Utilicé un diccionario para asociar cada opción del usuario con un método.
4- Le pedí al usuario que seleccione una opción y que ingrese los números.
5- Usé el delegado para ejecutar el método correspondiente según la opción elegida.

## Ejemplo de uso

### Entrada:
<img width="435" height="211" alt="Screenshot_1" src="https://github.com/user-attachments/assets/58c55f48-1208-4e2f-b928-28ba6b627523" />

### Salida:
<img width="499" height="290" alt="Screenshot_2" src="https://github.com/user-attachments/assets/916f47aa-987e-4645-9388-c0b88e7822ad" />

