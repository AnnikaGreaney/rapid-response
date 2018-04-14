require 'test_helper'

class UserTest < ActiveSupport::TestCase
  test "default user exists" do
    user = User.first
    assert_not user.nil?
    assert user.email == "annikagreaney@gmail.com"
  end
end
