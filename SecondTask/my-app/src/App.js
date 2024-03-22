import './App.css';
import React from 'react';

function App() {
  const [errorMessage, setErrorMessage] = React.useState("");

  function onSubmit(event) {
    event.preventDefault();
    console.log(event.target[0].value)
    console.log(event.target[1].value)
    if (event.target[0].value !== 'test@test.com' || event.target[1].value !== 'test'){
      setErrorMessage("Error!")
    }
  }

  return (
    <div>
      <form onSubmit={onSubmit}>
          <h2>Login</h2>
          <div>
            <input id="email" type="email" placeholder="Username" />
          </div>
          <div>
            <input id="password" type="password" placeholder="Password" />
          </div>
          <button type="submit">
            Submit
          </button>
        </form>
        {errorMessage && <div className="error"> {errorMessage} </div>}
    </div>
  );
}

export default App;
