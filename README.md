# Juego de plataformas diseñado en Unity

![Inicial](https://github.com/rmelgo/Anim-Juego-plataformas-Unity/assets/145989723/46bfb3bb-d0da-4e67-84c0-588a5a4ed426)

# - Introducción

Proyecto realizado en la asignatura de Animación Digital del grado de Ingenieria Informática de la Universidad de Salamanca. El enunciado del proyecto se encuentra subido en el repositorio en un archivo PDF llamado <a href="https://github.com/rmelgo/ANIM-Fusion-y-sombras/blob/main/Enunciado.pdf" target="_blank">*Enunciado_Unity.pdf*</a>.

El principal objetivo de este proyecto es la realización de un juego en Unity que cumpla una serie de requisitos básicos como:
- Manejo de diferentes modelos/sprites. 
- Uso de físicas 
- Gestión del componente Animator Controller. 
- Manejo de cámaras. 
- Scripts propios. 
- Sonidos 
- Varias Escenas. 

De esta manera, se utilizán las distintos conocimientos sobre Unity junto con el apoyo de varios assets gratuitos de la tienda de Unity que permitan diseñar el escenario del juego así como el personaje a manejar por el usuario.

# - Comentarios sobre el entorno de ejecución

Para ejecutar este programa, se requerirá de una distribución del Sistema Operativo **Windows**.    

Esto se debe a que el entorno de Unity funciona sobre Windows, además de que los ejecutables generados sólo pueden ejecutarse en Windows.

# Comentarios sobre el material adjuntado

El proyecto cuenta con los siguientes ficheros:

- Una carpeta llamada **Trabajo Unity** que contiene el proyecto Unity del juego de plataforma desarrollado y todo el material necesario para la construcción del juego.
  
  - Incluye un fichero ejecutable **Trabajo Unity.exe** en el cual se puede ejecutar el juego directamente.
  
- Un documento llamado **Trabajo_Unity.pdf** en el que se describe detalladamente el proceso de construcción del juego adjuntado capturas, código y explicaciones de los distintos pasos realizados en el desarrollo del juego.

# - Características del juego

Las características básicas del juego son las siguientes:

- El juego consta de 4 níveles que el personaje debe superar para ganar en el juego.
- Cada nivel cuentan con una serie de obstaculos, plataformas, etc que el personaje debe superar para pasar al siguiente nivel.
- Cada nivel cuenta con una puerta de entrada en la que el personaje empieza el nivel.
- Para pasar de nivel, el personaje debe alcanzar una puerta que marca el fin del nivel.
- Cada vez que el personaje muera debido a algún obstaculo, reaparecera de nuevo en la puerta que marca el inicio del nivel.
- El personaje se trata de un principe y la decoraración esta ambientada en un castillo medieval.
- El personaje puede moverse hacia los lados y saltar utilizando las flechas del teclado.
- El personaje puede realizar un segundo salto en el aire. Para ello, debe pulsarse de nuevo la flecha hacia arriba.
- En la esquina superior derecha existirá un pequeño contador que ira contabilizando el número de muertes del personaje.
- Al finalizar el juego, se mostrará el número de muertes acumulado por el personaje en los 4 niveles.

En el juego existen distintos tipos de obstaculos:

- **Nivel 1**: Este nivel incorpora saltos con diferentes plataformas y pinchos. Los pinchos pueden matar al personaje si este cae sobre ellos.

<p align="center">
  <img src="https://github.com/rmelgo/Anim-Juego-plataformas-Unity/assets/145989723/a2246b7a-25c8-47a5-83c5-a7929b63a802">
</p>

- **Nivel 2**: Este nivel incorpora los obtaculos del nivel anterior junto a las balas. Existen un par de cañones que disparan balas de manera periódica. Si el personaje es impactado por una bala, este morirá.

<p align="center">
  <img src="https://github.com/rmelgo/Anim-Juego-plataformas-Unity/assets/145989723/323c0643-e15d-4711-be4d-efe349e2069b">
</p>

- **Nivel 3**: Este nivel incorpora los obtaculos del nivel anterior junto a las ruedas de pinchos giratorias. Existen un par de ruedas de pinchos giratorias que se mueven a lo largo de un eje. Si el personaje es alcanzado por una una rueda giratoria, este morirá.

<p align="center">
  <img src="https://github.com/rmelgo/Anim-Juego-plataformas-Unity/assets/145989723/e47d013f-3314-4345-9ace-d59c85a1d9f2">
</p>

- **Nivel 4**: Este nivel incorpora los obtaculos del nivel anterior junto a las plataformas gravitarias. Existen algunas plataformas las cuales se vendrán abajo cuando el personaje se apoye sobre ellas. Al cabo de unos segundos, estas plataforman se repondrán para que el usuario siga teniendo opciones de pasarse el nivel.

<p align="center">
  <img src="https://github.com/rmelgo/Anim-Juego-plataformas-Unity/assets/145989723/bdc9ce65-2894-46e1-9cec-f9dc885f5198">
</p>

**Nota**: En el ejecutable del juego, las plataformas gravitatorias son invisibles debido a algún error de renderizado del juego, lo que le dota de un mayor componente de dificultad.

# - Ejemplo de ejecución

En el siguiente video, se adjunta una demostración del funcionamiento del juego:

[![Alt text](https://github.com/rmelgo/Anim-Juego-plataformas-Unity/assets/145989723/5e599318-b9c3-4fa1-a284-6ff5d71dc095)](https://youtu.be/B2mdTjsnM7k)

**Nota**: Hacer click a la imagen para acceder al video
