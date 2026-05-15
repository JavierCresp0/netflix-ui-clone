# 🎬 Netflix UI Clone · C# WPF

Clon de la **interfaz de Netflix** desarrollado como práctica de la asignatura **Interfaces de Usuario**. Construido con **WPF (Windows Presentation Foundation)** sobre **.NET** y **XAML** para el diseño declarativo de las vistas.

## ✨ Características

- 🏠 Pantalla de inicio con menú de navegación
- 🎬 Pantalla principal con catálogo de películas
- 🎞️ Vistas individuales para cada película
- 🧩 **UserControls** reutilizables para las tarjetas de película
- 🎨 Diseño inspirado en la UI real de Netflix

## 📁 Estructura del proyecto

```
Netflix.sln
└── Netflix/
    ├── App.xaml / App.xaml.cs          ← punto de entrada
    ├── MainWindow.xaml                 ← ventana de inicio (menú principal)
    ├── Principal.xaml                  ← pantalla principal (catálogo)
    ├── UCpelicula1.xaml                ← UserControl tarjeta de película
    ├── pelicula1.xaml / pelicula2.xaml ← vistas de detalle
    ├── interfaz.cs                     ← lógica de la interfaz
    ├── Properties/
    └── *.jpg, *.png                    ← recursos gráficos
```

## 🛠️ Tecnologías

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white)
![XAML](https://img.shields.io/badge/XAML-0C54C2?style=flat)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91?style=flat&logo=visual-studio&logoColor=white)

## 🎯 Conceptos aplicados

- Diseño de interfaces declarativas con XAML
- Modelo **code-behind** en WPF
- Creación de **UserControls** reutilizables
- Navegación entre ventanas
- Gestión de recursos gráficos
- Patrones de diseño de UI (inicio → home → detalle)

## 🚀 Cómo ejecutar

1. Abrir `Netflix.sln` con **Visual Studio 2019/2022**
2. Restaurar paquetes NuGet si es necesario
3. Pulsar **F5** o `Debug → Start Debugging`

> Requiere **.NET Framework** y Windows (WPF no es multiplataforma).

---

📌 *Práctica de la asignatura Interfaces de Usuario — Universidad Miguel Hernández.*
