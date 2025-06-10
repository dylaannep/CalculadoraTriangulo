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

## 🔍 Fuentes de consulta

## 🤖 Prompts y respuestas de IA utilizadas
¿Como capturo el mensaje de un usuario js con node?
1. Primero instala el paquete (una sola vez):
npm install prompt-sync
2. Luego en tu archivo fib.js:
const prompt = require('prompt-sync')();
let palabraIngresada = prompt('Ingrese una palabra: ');
console.log('Ingresaste:', palabraIngresada);

## 📄 Explicación Código
- El usuario ingresa los lados A, B y C.
- Se valida que se pueda formar un triángulo válido.
- Se calcula:
- El perímetro: a + b + c
- El semiperímetro: perímetro / 2
- El área con la fórmula de Herón
- El tipo según igualdad de lados
- Los ángulos usando la ley del coseno