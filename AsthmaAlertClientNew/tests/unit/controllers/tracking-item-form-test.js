import { module, test } from 'qunit';
import { setupTest } from 'ember-qunit';

module('Unit | Controller | tracking-item-form', function(hooks) {
  setupTest(hooks);

  // Replace this with your real tests.
  test('it exists', function(assert) {
    let controller = this.owner.lookup('controller:tracking-item-form');
    assert.ok(controller);
  });
});
