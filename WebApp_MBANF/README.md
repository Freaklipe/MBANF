# MBANF 
### Master Base ASP .Net Framework
Este proyecto es básico y tiene por función registrar, logear y mostrar usuarios, así como navegar entre sus páginas.

A nivel de navegación, solo consta de 3 pág:
1. Registro 
2. Login 
3. Principal del sistema.

La base de datos implementada es SqlServer con el uso de *EncryptByPassPhrase* para codificar las contraseñas y el uso hibrido de consulta directa y procedimiento almacenado, el primero
para crear el usuario y el segundo para validar su existencia, todo para hacer mas completo el ejemplo.

La definición del connectionString se realizó en el web.config y su consumo directo en los métodos.

La conexión se realizará usando la instancia clásica y básica de SqlCliente.

El manejo de validaciones es simple y reactivo a la necesidad del ejemplo.

El uso de bootstrap, jquery, js es directo en el html.

Recordar que este ejemplo es usando el Framework y no .Net Core 6 o superior

### Recursos
* Script BD en folder Recursos BD
* Bootstrap, Jquery, js por web


### Comentarios
El código en sí, esta burdo, se puede optimizar mucho. Sobre todo la forma de hacer las querys y pasar parámetros. Sin embargo, es un buen ejemplo funcional.




