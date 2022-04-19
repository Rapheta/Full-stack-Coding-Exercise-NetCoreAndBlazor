#  Ejemplo de ejercicio Full-Stack con tecnologías .NET Core (Back-end) y Blazor (Front-end)

**Sobre mí**

- Nombre: Rafael Castellet Ginard
- Correo electrónico: rafael.castelletginard@gmail.com
- LinkedIn: https://www.linkedin.com/in/rafael-castellet-ginard/

---------------------------------------------

Este es un pequeño ejercicio sobre la creación de un CRUD mediante la tecnología **.NET EntityFrameWork Core** y **Blazor**. Lo primero que se debe hacer es conectar un servicio .NET CORE a una base de datos. Mediante Blazor nos conectaremos a dicho servicio y crear así una Single Page Application. Además, para reducir la latencia de acceso a los datos y mejorar el tiempo de respuesta en nuestra aplicación se ha usado **Redis** puesta que es una excelente opción para implementar una caché de alta disponibilidad. Para mapear los objetos desde una base de datos a código C# vamos a usar **Dapper**. Este es seguramente el micro ORM más popular para ser utilizado en .NET, y está creado y mantenido por el equipo de Stack Overflow. 

| Blazor | .NET Core | SQL Server | Redis | Dapper |
|------------------- |---------------- |---------------- |---------------- |---------------- |
|<p align="center"><img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/blazor.png" width="60%"/></p>|<p align="center"><img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/netcore.png" width="32%"/></p>|<p align="center"><img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/sql-server.png" width="70%"/></p>|<p align="center"><img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/redis.png" width="100%"/></p>|<p align="center"><img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/dapper.png" width="100%"/></p>|

Esta aplicación o proyecto Web simula la gestión de un centro de educación. Mediante la aplicación el usuario puede añadir alumnos al centro, profesores, asignaturas y finalmente gestionar las calificaciones de los alumnos.

Los pasos a seguir para implementar esta aplicación son:

- Creación de una base de datos
- Creación del servicio MVC .NET Core
- Creación de la aplicación Blazor (Presentación)

El diseño de nuestra base de datos sería el que se muestra en la imagen:

<img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/database.jpg" width="100%"/>

A continuación se muestran imágenes de la aplicación realizada con los mantenimientos correspondientes a la sección de alumnos, profesores, asignaturas así como también la evaluación.

## FRONT-END

**Página principal**

<img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/Home.jpg" width="100%"/>

**Mantenimiento de los alumnos**

<img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/Alumnos1.jpg" width="100%"/>

<img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/Alumnos2.jpg" width="100%"/>

**Mantenimiento de los profesores**

<img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/Profesores1.jpg" width="100%"/>

<img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/Profesores2.jpg" width="100%"/>

**Mantenimiento de las asignaturas**

<img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/Asignaturas.jpg" width="100%"/>

**Mantenimiento de las evaluaciones**

<img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/Evaluacion1.jpg" width="100%"/>

<img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/Evaluacion2.jpg" width="100%"/>


## BACK-END

**Documentación de la API**

<img src="https://github.com/Rapheta/Full-stack-Coding-Exercise-NetCoreAndBlazor/blob/master/images/Api.jpg" width="100%"/>
