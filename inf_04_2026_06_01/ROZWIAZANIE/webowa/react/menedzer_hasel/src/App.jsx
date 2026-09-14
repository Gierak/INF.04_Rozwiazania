import { useState, useRef } from "react";

function App() {
  const referencja_pole_haslo = useRef(null);
  const [generujHaslo, ustawGenerujHaslo] = useState(true);
  const [dane, ustawDane] = useState({
    adres: "",
    login: "",
    haslo: "",
    wygenerowano_haslo: true,
  });

  const zapiszDane = (event) => {
    event.preventDefault();
    const daneFormularza = new FormData(event.target);

    ustawDane({
      adres: daneFormularza.get("adres") ?? "",
      login: daneFormularza.get("login") ?? "",
      haslo: daneFormularza.get("haslo") ?? "",
      wygenerowano_haslo: daneFormularza.get("wygenerowane_haslo") ?? false,
    });
  };

  return (
    <div className="m-2">
      <section id="blok1">
        <h1>Menedżer haseł - wykonał 12345678901</h1>
        <form onSubmit={zapiszDane}>
          <div className="form-group m-4">
            <label htmlFor="input_strona">Adres WWW:</label>
            <input
              type="text"
              className="form-control"
              id="input_strona"
              name="adres"
              placeholder="Adres strony WWW"
            />
          </div>
          <div className="form-group m-4">
            <label htmlFor="input_login">Login:</label>
            <input
              type="text"
              className="form-control"
              id="input_login"
              name="login"
              placeholder="Twój login"
            />
          </div>

          <div className="form-group m-4">
            <div className="form-group d-flex flex-row gap-2">
              <input
                type="checkbox"
                id="input_checkbox_wygeneruj_haslo"
                name="wygenerowane_haslo"
                checked={generujHaslo}
                onChange={(el) => {
                  referencja_pole_haslo.current.value = "";
                  ustawGenerujHaslo(el.target.checked);
                }}
              />
              <label htmlFor="input_checkbox_wygeneruj_haslo">
                Wygeneruj hasło
              </label>
            </div>
            <label htmlFor="input_haslo">Hasło:</label>
            <input
              type="password"
              className="form-control"
              id="input_haslo"
              name="haslo"
              ref={referencja_pole_haslo}
              disabled={generujHaslo}
            />
          </div>
          <button type="submit" className="btn btn-primary">
            Zapisz
          </button>
        </form>
      </section>
      <section id="blok2">
        <p className="p-2 text-primary lead">Adres: {dane.adres}</p>
        <p className="p-2">Login: {dane.login}</p>
        <p className="p-2">
          {" "}
          {dane.wygenerowano_haslo
            ? "Hasło automatycznie generowane"
            : "Hasło: " + dane.haslo}
        </p>
      </section>
    </div>
  );
}

export default App;
