<h3>Lista tych śmiesznych produktów</h3>

<style>
    
    td, th, table {
        border:1px solid black;
        border-collapse: collapse;
    }
    body {
        font-size: 1.2em;
    }
</style>

<div>
    <table>

        <tr>
            <th>nazwa</th>
            <th>opis</th>
            <th>cena</th>
        </tr>
    
        @foreach ($products as $product)
            <tr>
                <td>{{$product["name"]}}</td>
                <td>{{$product["description"]}}</td>
                <td>{{$product["price"]}}</td>
            </tr>
        @endforeach

    </table> <br>

    <a href="/product/create">Nowy</a>
    
</div>
