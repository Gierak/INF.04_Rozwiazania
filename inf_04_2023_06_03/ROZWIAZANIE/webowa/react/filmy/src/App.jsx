import { useState } from "react";
import "./App.css";

function App() {
  const [tytul, setTytul] = useState("");
  const [rodzaj, setRodzaj] = useState();

  function ZatwierdzFormularz(event) {
    event.preventDefault();
    console.log(`tytul: ${tytul}; rodzaj: ${rodzaj}`);
  }

  return (
    <>
      <div className="container">
        <div className="col">
          <form onSubmit={ZatwierdzFormularz}>
            <div className="form-group mb-3">
              <label htmlFor="tytulFilmu">Tytuł filmu</label>
              <input
                type="text"
                className="form-control"
                id="tytulFilmu"
                onChange={(it) => {
                  setTytul(it.target.value);
                }}
              />
            </div>

            <div className="form-group mb-3">
              <label htmlFor="rodzaj">Rodzaj</label>
              <select
                id="rodzaj"
                className="form-control form-select"
                onChange={(it) => {
                  setRodzaj(it.target.value);
                }}
              >
                <option></option>
                <option value="1">Komedia</option>
                <option value="2">Obyczajowy</option>
                <option value="3">Sensacyjny</option>
                <option value="4">Horror</option>
              </select>
            </div>

            <button type="submit" className="btn btn-primary">
              Dodaj
            </button>
          </form>
        </div>
      </div>
    </>
  );
}

export default App;
