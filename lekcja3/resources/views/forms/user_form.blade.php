<style>
    body {
        background-color: black;
        color: white;
    }
</style>

<div>
    <h3>Dane użytkownika</h3>
    <p>Podaj te śmieszne dane</p>

    @if($errors->any())
        <p>Błędy:</p>
        <ul>
            @foreach($errors->all() as $error)
                <li>{{$error}}</li>
            @endforeach
        </ul>
    @endif

    <form action="UserFormController" method="GET">
        <input type="text" name="firstName" placeholder="Podaj imię" autofocus> <br> <br>
        <input type="text" name="lastName" placeholder="Podaj nazwisko"> <br> <br>
        <input type="text" name="city" placeholder="Podaj miasto"> <br> <br>
        <input type="text" name="hobbies" placeholder="Podaj hobby po przecinku"> <br> <br>
        <input type="submit" value="Zatwierdź dane">
    </form>
</div>
