import React, {useState} from 'react';
import Perfil from './componentes/Perfil'

function App() {
  const [nombre, cambiarNombre] = useState("Sin Nombre")
  
  function eventoCajaTexto(e) {
    cambiarNombre(e.target.value);
  }
  
  return (
    <div>
      <h1>Bienvenido {nombre} al curso de ASP.NET Core y React Hooks! </h1>
      <input type="text" name="nombre" onChange={eventoCajaTexto} value={nombre} />
      {/* Pasando propiedades de padres a hijos */}
      <Perfil atributo={nombre}/>
    </div>
  );
}

export default App;
