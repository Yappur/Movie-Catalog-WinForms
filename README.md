# 🎬 Catálogo de Contenido Audiovisual

![Catálogo de contenido audiovisual](https://i.imgur.com/QVW0n3A.png)

Proyecto académico correspondiente a los TPs 4 y 5 de la materia Programación 2. Es la continuación de los TP 1, TP 2 y TP 3 y consiste en un sistema de gestión de contenido audiovisual desarrollado con C# y Windows Forms.
Este trabajo práctico busca integrar y ampliar conceptos vistos en los trabajos previos: modelado de clases, colecciones y operaciones sobre datos, incorporando además una interfaz gráfica y validaciones de entrada.

## 🎯 Objetivo

Diseñar una aplicación de escritorio que permita cargar, visualizar y administrar un catálogo de películas y series, aplicando principios de programación orientada a objetos.

## ✨ Funcionalidades

- Visualizar una lista de películas y series en un DataGridView.
- Agregar nuevas películas o series.
- Seleccionar género mediante un ComboBox (enum `Genero`).
- Elegir si el contenido es Película o Serie (RadioButton) y mostrar campos específicos según la elección.
- Validar los datos antes de agregarlos.
- Buscar contenido por nombre, director o género.
- Filtrar por género.
- Ordenar resultados por año.
- Eliminar contenidos seleccionados.
- Mostrar información detallada de un contenido.
- Marcar contenidos como destacados (CheckBox).
- Limpiar el formulario y Filtro.

## 🧱 Programación Orientada a Objetos

El diseño del dominio aprovecha los pilares de la POO para representar de forma clara los distintos tipos de contenido.

### Herencia

La clase base `ContenidoAudioVisual` agrupa las propiedades comunes (por ejemplo: Nombre, Director, Año, Género, Destacado). De ella heredan dos clases concretas:

- `Pelicula`: añade la propiedad `DuracionMinutos`.
- `Serie`: añade la propiedad `Temporadas`.

Esto evita duplicación de código y centraliza atributos compartidos.

### Polimorfismo

La aplicación usa una colección del tipo `List<ContenidoAudioVisual>` que puede contener instancias de `Pelicula` y `Serie`. Gracias al polimorfismo, el código trata homogéneamente los elementos de la lista (por ejemplo, al mostrarlos o iterar para buscar), mientras cada objeto conserva sus datos y comportamiento específicos.

Ejemplo conceptual: una variable declarada como `ContenidoAudioVisual` puede referenciar tanto a una `Pelicula` como a una `Serie` y, al invocar métodos o acceder a propiedades, se aplicará la implementación correspondiente al tipo real del objeto.

### Encapsulamiento

Las clases exponen sus datos mediante propiedades públicas y mantienen la lógica de validación en la capa de interfaz o en métodos específicos cuando corresponde, siguiendo el principio de ocultar la implementación interna.

### Enum y colecciones

- `enum Genero`: representando los géneros disponibles y utilizado en el ComboBox.
- `List<ContenidoAudioVisual>`: colección principal que almacena el catálogo.

## 🔎 LINQ

Se emplea LINQ para realizar consultas sobre la colección de contenidos. En el código se utilizan métodos como:

- `Where()`: filtra la colección según una condición (por ejemplo, buscar por nombre, director o género).
- `OrderBy()`: ordena la secuencia (por ejemplo, por año ascendente).
- `ToList()`: materializa el resultado de la consulta en una lista para enlazarla al DataGridView o iterar sobre ella.

Estas operaciones hacen las búsquedas, filtros y ordenamientos más expresivos y concisos.

## ✅ Validaciones

Antes de agregar un contenido, el formulario valida varios campos, entre ellos:

- El nombre no debe estar vacío.
- Debe seleccionarse un género.
- El director no puede estar vacío.
- El año debe ser un número válido (se comprueba con `int.TryParse()`).
- Para `Pelicula`: la duración en minutos debe ser un número válido (`int.TryParse()`).
- Para `Serie`: la cantidad de temporadas debe ser un número válido (`int.TryParse()`).

El uso de `int.TryParse()` permite detectar entradas no numéricas sin lanzar excepciones y manejar errores de forma amigable.

## 🖥️ Interfaz gráfica

La interfaz está construida con Windows Forms y emplea controles estándar:

- DataGridView: muestra la lista del catálogo y permite la selección de registros para ver detalles o eliminarlos.
- ComboBox: para seleccionar el género.
- RadioButton: para elegir entre Película y Serie; al cambiar la selección se muestran u ocultan campos específicos.
- CheckBox: para marcar un contenido como destacado.
- MessageBox: para mostrar mensajes de validación, confirmaciones o errores.

Los eventos de los controles (clic en botones, selección de fila, cambio de RadioButton/ComboBox) controlan la lógica de la aplicación y actualizan la vista.

## 🏗️ Estructura de clases

ContenidoAudioVisual
├── Pelicula
└── Serie

`Pelicula` y `Serie` heredan de `ContenidoAudioVisual` y añaden sus campos específicos (`DuracionMinutos` y `Temporadas`, respectivamente).

## 🛠️ Tecnologías utilizadas

- C#
- .NET (Windows Forms)
- LINQ
- Colecciones genéricas (`List<T>`)
- Controles de Windows Forms: `DataGridView`, `ComboBox`, `RadioButton`, `CheckBox`, `MessageBox`
- Git / GitHub (control de versiones)

## 🚀 Ejecución del proyecto

1. Abrir la solución del proyecto (.sln) con Visual Studio.
2. Compilar y ejecutar la aplicación desde el IDE.


