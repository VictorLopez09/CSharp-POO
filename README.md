# 🛒 Tienda en Línea – Proyecto POO en C#

## 📌 Descripción del Proyecto

Este proyecto es una **aplicación de consola en C#** que simula una **tienda en línea** donde los usuarios pueden **visualizar un catálogo de productos**, **seleccionar productos dinámicamente** y **agregarlos a un carrito de compras**.

El sistema fue desarrollado con el objetivo de **aplicar y demostrar los principales conceptos de la Programación Orientada a Objetos (POO)** de forma clara y práctica.

---

## 🎯 Funcionalidades

* Mostrar un **catálogo dinámico de productos**
* Seleccionar productos mediante un menú
* Manejar diferentes tipos de productos
* Calcular el **precio final** según el tipo de producto
* Agregar productos a un carrito
* Mostrar el total de la compra

---

## 🧱 Estructura del Proyecto

### 📂 Clases Principales

* **Product (Clase abstracta)**

  * Define las propiedades y métodos comunes
* **DigitalProduct**

  * Producto descargable (no tiene envío)
* **PhysicalProduct**

  * Producto físico (incluye costo de envío)
* **ShoppingCart**

  * Administra la lista de productos seleccionados
* **Program**

  * Controla la interacción con el usuario

---

## 🧠 Conceptos de Programación Orientada a Objetos Utilizados

| Concepto          | Aplicación en el Proyecto                                   |
| ----------------- | ----------------------------------------------------------- |
| **Herencia**      | `DigitalProduct : Product`, `PhysicalProduct : Product`     |
| **Polimorfismo**  | Método `CalculateFinalPrice()` con diferente comportamiento |
| **Encapsulación** | Lista de productos privada en el carrito                    |
| **Abstracción**   | Clase abstracta `Product`                                   |
| **Propiedades**   | `Name`, `Price`                                             |
| **Objetos**       | Creación de productos con `new DigitalProduct()`            |

---

## 🧩 Explicación General

Esta aplicación de consola simula una tienda en línea donde el usuario puede seleccionar productos desde un catálogo y agregarlos a un carrito de compras. El sistema utiliza principios de Programación Orientada a Objetos como herencia, polimorfismo, encapsulación y abstracción para manejar distintos tipos de productos y calcular sus precios finales de manera dinámica.

Gracias a esta estructura, el proyecto es **escalable**, permitiendo agregar nuevos tipos de productos fácilmente sin modificar el código existente.

---

## 🚀 Tecnologías Utilizadas

* Lenguaje: **C#**
* Paradigma: **Programación Orientada a Objetos**
* Tipo de aplicación: **Consola**

---

## 📚 Objetivo Académico

Este proyecto fue desarrollado con fines educativos para reforzar el aprendizaje de:

* Clases y objetos
* Herencia y polimorfismo
* Encapsulación y abstracción
* Uso de propiedades
* Diseño limpio y reutilizable

---

## ✅ Posibles Mejoras Futuras

* Guardar historial de compras
* Aplicar descuentos
* Manejar usuarios
* Implementar interfaces
* Convertirlo en aplicación gráfica
