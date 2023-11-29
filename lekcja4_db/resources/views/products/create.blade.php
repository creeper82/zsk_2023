<style>
    body {
        font-size: 1.2em;
    }
</style>

<h3>Nowy produkt</h3>

<form action="{{route("product.store")}}" method="post">
    @csrf
    <label for="name">Nazwa</label> <br>
    <input type="text" name="name" id="name"> <br>
    <label for="description">Opis</label> <br>
    <input type="text" name="description" id="description"> <br>
    <label for="price">Cena</label> <br>
    <input type="number" name="price" id="price"> <br>
    <input type="submit" value="Dodaj">
</form>