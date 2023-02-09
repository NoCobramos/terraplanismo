/* esto es el producto */
class Producto {
  constructor(name, email, comentario){
      this.name = name;
      this.email = email;
      this.comentario=comentario;
  }
}
/*esto es la interfas de agregacion */
class UI{
    addProduct(producto){
       const producList = document.getElementById("producList");
       const Element = document.createElement("div");
       Element.innerHTML = `
        <div class="comentarios">
                     <table>
                        <tr>
                            <td><img src="img/img-info/icono_fecha.gif" /></td>
                            <th>18-11-2022 07:23 ${producto.email}</th>
                            <td> <img src="img/img-info/icono_autor.gif" /></td>
                            <th> <a href=""> ${producto.name}</a></th>
                            <td> <img src="img/img-info/icono_comentarios.gif" /></td>
                            <th><a href="">Añadir comentario</a></th>
                            <th><a href="#" class="btn2" name="delete">X</a>
                            </th>
                        </tr>
                    </table>
                    <p>
                    ${producto.comentario}
                    </P>
                    </div>
       `;
       producList.appendChild(Element) 
       this.ResetFormulari
    }
/* para resetear el formulario*/ 
    ResetFormulari(){
        document.getElementById("PF").reset();
    }
/*Elimina el objeto  */
    deleteProduct(Element){
        if(Element.name == "delete"){
            Element.parentElement.parentElement.parentElement.parentElement.parentElement.remove()
            this.showMenssage("eliminado correctamente", "delete")
        }else {
            alert("no te esta funcionando")
        }
    }
/*sona del mensaje de alerta y verificado urgente areglar la eliminacion de los mensajes */
    showMenssage(mensaje, cssStail){
        var div = document.createElement('div');
        div.classList.add("Alert");
        
        div.appendChild(document.createTextNode(mensaje));
        //mostrando en el DON
        const conntenedor = document.querySelector(".contenedor");
        const app = document.querySelector("#App");
        conntenedor.insertBefore(div, app);
        setTimeout(function () {
            document.querySelector(".Alert").remove();
        }, 3000); // salta alerta en consola para intentar eliminarlo pero no encuentra el objeto 

    }
}
/*sumador de presios*/

 /* Eventos del DOMW */
 document.getElementById("PF")
    .addEventListener("submit", function(e){
        const name = document.getElementById("name").value;
        const email = document.getElementById("email").value;
        const comentario = document.getElementById("comentario").value;
        const producto = new Producto(name, email, comentario);
        const ui = new UI ();
        // evita entradas no correctas en el formulario 
        ui.addProduct(producto);
        ui.ResetFormulari();
        e.preventDefault(); 
        ui.showMenssage("prducto agregado con exito", 'cardsave');
        // evita que se refresque la pagina 
        
 });
document.getElementById("producList")
    .addEventListener("click", function(e){
        const ui= new UI();
        ui.deleteProduct(e.target);
})