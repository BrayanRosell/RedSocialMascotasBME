const URL_BASE = 'https://localhost:44305/';

  //********************************  G  E  T   **************************///
  describe('Home carga Correctamente', () => {
    it('Home cargo', () => {

      cy.request({

          method: 'GET',
          url: URL_BASE
      }).then,((resp)=>{

        expect(resp.status).to.equal(200);
      })
    })
  })
  ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
  