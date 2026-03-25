# 🎯 AR Rally — Ingeniería de Sistemas JDC

> Experiencia de Realidad Aumentada gamificada para dar a conocer el programa de **Ingeniería de Sistemas** de la Fundación Universitaria Juan de Castellanos.

![Unity](https://img.shields.io/badge/Unity-000000?style=flat-square&logo=unity&logoColor=white)
![Vuforia](https://img.shields.io/badge/Vuforia-RA-blue?style=flat-square)
![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=csharp&logoColor=white)
![Estado](https://img.shields.io/badge/Estado-Completado-brightgreen?style=flat-square)

---

## 📖 Descripción

**AR Rally** es una aplicación móvil de Realidad Aumentada diseñada como herramienta de divulgación del programa de Ingeniería de Sistemas de la **Fundación Universitaria Juan de Castellanos (JDC)**. A través de una dinámica de rally interactivo, los participantes responden preguntas, descifran pistas y usan su dispositivo móvil para descubrir objetos 3D en el mundo real.

---

## 🎮 ¿Cómo funciona?

```
1. El jugador recibe una pregunta
        ↓
2. Al responder correctamente → obtiene una pista de ubicación
        ↓
3. Se dirige a la ubicación indicada
        ↓
4. Escanea un marcador QR con la app (Vuforia)
        ↓
5. Aparece un objeto 3D en Realidad Aumentada
        ↓
6. Al seleccionar el objeto → suma un punto
        ↓
7. Pasa a la siguiente etapa del rally
```

---

## 📸 Capturas

> Agrega tus capturas en la carpeta `docs/images/` y reemplaza los enlaces de abajo.

| Vista del juego | Marcador AR | Objeto 3D |
|:-:|:-:|:-:|
| ![Gameplay](docs/images/gameplay.png) | ![Marker](docs/images/marker.png) | ![Object](docs/images/object3d.png) |

🎥 **Video demo:** [Ver en YouTube](https://youtube.com/tu-link)

---

## 🛠️ Tecnologías

| Herramienta | Uso |
|---|---|
| **Unity** | Motor de desarrollo del juego |
| **Vuforia** | Reconocimiento de marcadores y RA |
| **C#** | Lógica del juego y mecánicas |
| **Android** | Plataforma objetivo |

---

## 📋 Requisitos

- Unity 2021.x o superior
- Vuforia Engine SDK
- Android 8.0+ / iOS 12+
- Cámara trasera funcional

---

## 🚀 Instalación y uso

### Opción 1 — Abrir en Unity
```bash
# Clona el repositorio
git clone https://github.com/SebasGomez19/AR-Rally-SistemaJDC.git

# Abre Unity Hub → Add → selecciona la carpeta del proyecto
# Espera que cargue la carpeta Library (se genera automáticamente)
```

### Opción 2 — APK directo
> 📦 Próximamente disponible en la sección de [Releases](https://github.com/SebasGomez19/AR-Rally-SistemaJDC/releases)

---

## 📁 Estructura del proyecto

```
AR-Rally-SistemaJDC/
├── Assets/
│   ├── Scenes/          # Escenas del juego
│   ├── Scripts/         # Lógica en C#
│   ├── Prefabs/         # Objetos 3D y prefabs
│   └── StreamingAssets/ # Base de datos Vuforia
├── Packages/
├── ProjectSettings/
└── docs/
    └── images/          # Capturas del proyecto
```

---

## 👥 Contexto académico

Proyecto desarrollado en la **Fundación Universitaria Juan de Castellanos (JDC)** con el objetivo de promover y dar a conocer el programa de **Ingeniería de Sistemas** a través de experiencias inmersivas de Realidad Aumentada.

---

## 📄 Licencia

Este proyecto está bajo la licencia [MIT](LICENSE).

---

<div align="center">
<sub>Desarrollado por <a href="https://github.com/SebasGomez19">Sebastián Felipe Gómez Alba</a> · Fundación Universitaria Juan de Castellanos</sub>
</div>
