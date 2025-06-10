# Calculadora de Trigonometria 
Este proyecto le permite al usuario ingresar los lados de un triángulo y obtener de forma automatica los siguientes resultados:
- El perimetro
- El semiperimetro
- El área
- El tipo de triángulo (equilatero, isósceles o escaleno)
- Los ángulos internos calculados con la Ley del Coseno
Este proyecto fue desarrollado con ASP.NET Core MVC, C# y Bootstrap

## 🧑‍💻 Autor
- Estudiante: Dylan Andrés Espinoza Pereira
- Carné: FH23013870
- Profesor: Luis Andrés Rojas Matey
- Universidad Fidélitas
- Curso: Programación Avanzada en Web
- Año: 2025

## 📁 Archivos del Proyecto
- TrianguloModel.cs: Modelo con propiedades y validaciones de los lados y resultados.

- TrianguloController.cs: Controlador principal que recibe los datos, realiza los cálculos y retorna la vista.

- Index.cshtml: Vista que contiene el formulario para ingresar los lados y mostrar los resultados.

## 🌐 Enlace al repositorio
[GitHub - dylaannep/CalculadoraTriangulo](https://github.com/dylaannep/CalculadoraTriangulo.git)


## 🔍 Fuentes de consulta
[Ley de Cosenos](https://openstax.org/books/precálculo-2ed/pages/8-2-triangulos-no-rectangulos-ley-de-cosenos)
[Trigonometria](https://es.wikipedia.org/wiki/Trigonometría)

## 🤖 Prompts y respuestas de IA utilizadas
¿Cómo se calcula el área del triángulo?
Fórmula de Herón:
Primero se calcula el semiperímetro
Luego se utiliza la formula de Raiz(s * (s - a) * (s - b) * (s - c))

Es necesario agregar la logica de las operaciones en el modelo o tambbien se puede en el controller
Sí puedes hacer lógica en el controlador si es de flujo, pero la lógica de operaciones matemáticas como el cálculo del área, pero también puede estar en el modelo.



## 📄 Explicación Código
- El usuario ingresa los lados A, B y C.
- Se valida que se pueda formar un triángulo válido.
- Se calcula:
- El perímetro: a + b + c
- El semiperímetro: perímetro / 2
- El área con la fórmula de Herón
- El tipo según igualdad de lados
- Los ángulos usando la ley del coseno

## 📄 Comandos de dotnet para crear la solución y el proyecto
- Crear la solucion del proyecto: dotnet new sln -n Tarea2DylanEP
- Crear el proyecto MVC: dotnet new mvc -o TareaTrigonometria
- Agregar el proyecto a la solución: dotnet sln add TareaTrigonometria 
- Entrar al directorio del proyecto: cd TareaTrigonometria  
- Hacer pruebas con el proyecto terminado: dotnet run 