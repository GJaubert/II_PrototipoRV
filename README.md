# II_PrototipoRV
## Interfaces Inteligentes
Prototipo en Realidad Virtual compatible con Google Cardboard para la asignatura de Interfaces Inteligentes en la Universidad de La Laguna

## Componentes del grupo
- Viren Sajju Dhanwani Dhanwani
- José Daniel Escánez Expósito
- Gabriel García Jaubert
- Ángel Tornero Hernández

## Cuestiones importantes para el uso
- Compatible solo con Android, probado en la versión 11.
- Se requiere de gafas de Realidad Virtual para dispositivo móvil, por ejemplo las Google Cardboard.
- Se necesita un mando compatible con el dispositivo Android, se probó con un mando de PlayStation 4.
- [Instalar APK](https://www.xataka.com/basics/instalar-apk-en-android-como-hacerlo-y-cuales-son-los-riesgos).
- Mejor experiencia con auriculares para apreciar el sonido espacial.
- Recomendable jugar de pie antes que sentado.
- Dar permisos de ubicación a la aplicación.

## Hitos de programación
- Utilización de componentes físicos, como _RigidBody_ o _colliders_ y atributos, por ejemplo _isTrigger_.
- Bloquear rotaciones en los correspondientes ejes mediante código.
- Objeto se orienta hacia el jugador en todo momento.
- Utilización de eventos.
- Retícula que se abre cuando se posiciona sobre un objeto interactuable.
- Agarre de objetos interactuables.
- Abrir objetos como taquillas o cajas fuerte mediante el uso de animaciones y la típica interacción llave-puerta.
- Gestión de escenas distintas con transiciones también suavizadas.
- Evaluación de las decisiones para escoger la escena final del jugador.

## Aspectos a destacar
- Interfaces multimodales: localización mediante GPS.
- Sonidos ambientales, espaciales y efectos sonoros.
- Desplazamiento del jugador mediante teletransporte suavizado gracias a transiciones _fade_in/fade_out_.
- La música y los _assets_ se gestionan en cada escena para generar distintas atmósferas.
- Restricción del desplazamiento del jugador sobre el plano del suelo.
- Mundo abierto pero locomoción limitada por obstáculos (vallas, paredes, mar)
- Todos los objetos interactuables desde la altura del usuario (evitando posiciones y giros de cuello incómodos)
- Todos los objetos están bien escalados y posicionados para situar y guiar espacialmente al usuario
- El suelo de las escenas ayuda a entender la altura correcta en la que se encuentra el usuario
- Retícula contextual mínima para ubicar el centro con un color adecuado para que sea visible en todas las escenas
- Plataforma de teletransporte en la proyección de la retícula sobre el terreno
- Las preguntas del juego se pueden leer y escuchar
- Fundido en negro en los cambios de escena y cuando se usa el teletransporte para evitar mareos
- Pantalla de inicio con los controles antes de empezar la experiencia
- Todos los objetos no son interactuables por la mecánica (juego de escape)
- El usuario no tiene ninguna razón para mirar más de 60º hacia arriba y 40º hacia abajo, todas las interacciones han sido diseñadas para facilitar la comodidad de la experiencia

## Acta del distribución del trabajo

[Enlace al acta](https://docs.google.com/document/d/1tyVVz5mZGjYmDusfFmcLtjEUNxtCVmliEoC1q0QSjBk/edit?usp=sharing)
