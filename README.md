# Laboratorio #3

**Fecha:** 14/09/2026

## Contenido del Repositorio

Esta práctica corresponde al **Laboratorio #3** y contiene dos ejercicios desarrollados en C# utilizando Windows Forms. El primer problema trabaja con un `DataGridView` para mostrar y administrar información de objetos, mientras que el segundo problema consiste en la implementación de un juego basado en las reglas de Craps.

### Problema 1: DataGridView

El **DataGridView** se utiliza en Windows Forms para mostrar y editar datos en formato de tabla, organizados mediante filas y columnas. En este ejercicio se trabajó con este componente para presentar información de objetos de manera ordenada y permitir su visualización desde la interfaz gráfica.

Entre sus principales usos se encuentran:

- Mostrar listas de objetos, arreglos o colecciones de datos.
- Conectarse directamente a bases de datos, como MySQL o SQL Server, para visualizar consultas o tablas completas.
- Permitir al usuario interactuar con la información mediante celdas.
- Agregar nuevos registros o modificar datos existentes de forma visual.

### Problema 2: Juego de Craps

El segundo ejercicio consiste en un juego basado en las reglas de **Craps**, un juego de dados de casino en el que un jugador actúa como tirador.

Las reglas principales son:

- El tirador realiza la **tirada de salida**.
- Si obtiene un **7 o un 11** en la tirada de salida, ganan las apuestas de línea de pase.
- Si obtiene **2, 3 o 12**, las apuestas de línea de pase pierden.
- Cualquier otro número obtenido se convierte en el **punto**.
- Después de establecerse el punto, el tirador continúa lanzando los dados hasta que:
  - Vuelva a obtener el número del punto, lo que representa una ganancia para las apuestas de línea de pase.
  - Obtenga un **7**, lo que representa una pérdida para las apuestas de línea de pase.

## Tecnologías Utilizadas

- **C#**
- **.NET**
- **Git**
- **Windows Forms**

## Capturas de Pantalla y Problemas

### Interfaz Principal

A continuación se incluye la captura de pantalla correspondiente a la salida de los ejercicios realizados en el laboratorio.

![Interfaz Principal](attachment:0262d036-29e1-4a49-b226-4c0a783a7fe4/Screenshot_2026-09-13_190619.png)

### Problema / Ejercicio 1: DataGridView

En este ejercicio se implementó un **DataGridView** dentro de una aplicación Windows Forms para mostrar información de forma organizada en filas y columnas.

La solución permite trabajar con una lista de objetos y presentar sus datos visualmente en la interfaz. De esta manera, el usuario puede observar la información de los registros de una forma más clara y ordenada.

El uso del DataGridView facilita la visualización de los datos y permite que la aplicación pueda manejar colecciones de información sin tener que mostrar cada elemento de manera individual.

![DataGridView - Ejercicio 1](attachment:d51ba350-c611-4bcb-8c25-701dbf14f518/Screenshot_2026-09-14_084355.png)

### Problema / Ejercicio 2: Juego de Craps

En este ejercicio se desarrolló un **juego de Craps** basado en las reglas indicadas anteriormente.

La salida del programa permite realizar las tiradas de los dados y determinar el resultado correspondiente. Primero se realiza una tirada de salida y, dependiendo del número obtenido, el programa determina si la jugada es ganadora, perdedora o si debe establecerse un punto.

Cuando se establece un punto, el juego continúa realizando tiradas hasta que se obtiene nuevamente el número del punto o aparece un 7. De esta manera, el programa representa mediante una interfaz gráfica el funcionamiento básico de una partida de Craps y muestra al usuario el resultado de cada jugada.

## Estructura de Carpetas o Directorios

El repositorio puede organizarse de la siguiente manera:

```text
mi-repositorio/
├── app/          # Lógica principal de la aplicación
├── config/       # Archivos de configuración
└── README.md     # Documentación del proyecto
