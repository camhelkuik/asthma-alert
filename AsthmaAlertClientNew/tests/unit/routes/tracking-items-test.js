import { module, test } from 'qunit';
import { setupTest } from 'ember-qunit';

module('Unit | Route | tracking-items', function(hooks) {
  setupTest(hooks);

  test('it exists', function(assert) {
    let route = this.owner.lookup('route:tracking-items');
    assert.ok(route);
  });
});
