import React from 'react';
import { Container } from 'reactstrap';

const Layout = function (props) {
  return (
    <div>
      <Container>
        { props.children }
      </Container>
    </div>
  );
}

export default Layout;